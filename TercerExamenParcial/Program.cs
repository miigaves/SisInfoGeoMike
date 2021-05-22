using System;
using System.Linq;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using static System.Console;
using System.Collections.Generic;
namespace TercerExamenParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            WriteLine("\t\tPAGINA A REALIZAR UN SCRIPPING: https://es.pdfdrive.com \n\n Comenzando extraccion de informacion...\n\n");

            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://es.pdfdrive.com");

            //instanciamos nuestras herramientas.
            int libroID = 0;
            List<Libro> libros = new List<Libro>();
            List<Info> informacion = new List<Info>();
            DataContext db = new DataContext();



            //obtenemos todas las categorias.
            var listCategories = doc.DocumentNode.SelectNodes("//div[@class='categories-list']//a[@href]").Select(a=>a.Attributes["href"].Value);
            foreach(var e in listCategories){
                string _dir ="https://es.pdfdrive.com";
                _dir+=e.ToString();
                doc = web.Load(_dir);
                   
                   //accedemos a la categoria 
                   string _categorias = doc.DocumentNode.SelectSingleNode("//div[@class='collection-title']").InnerText;
                   var _title = doc.DocumentNode.SelectNodes("//div[@class='file-right']/a/h2");
                   WriteLine("\n"+_categorias.ToUpper()+" \n");

                   if(_title is not null ){//verificamos la categoria tenga libros que obtener.
                       var books = doc.DocumentNode.SelectNodes("//div[@class='file-right']//a[@href]");//obtenemos los libros de cada categoria
                    
                        foreach(var t in books){
                            Libro libro = new Libro();
                            Info info= new Info();
                            string _dirlinks = "https://es.pdfdrive.com"+t.Attributes["href"].Value;
                            doc = web.Load(_dirlinks);
                            libroID++;
                                
                            //obtenemos la informacion para llenar la tabla. 
                            libro.libroID = libroID;
                            libro._nombreLibro = doc.DocumentNode.SelectSingleNode("//div[@class='ebook-right-inner']/h1").InnerText;
                            libro._paginas = doc.DocumentNode.SelectSingleNode("//div[@class='ebook-file-info']/span[1]").InnerText;
                            libro._fechaPublicacion = doc.DocumentNode.SelectSingleNode("//div[@class='ebook-file-info']/span[3]").InnerText;
                            libro._peso = doc.DocumentNode.SelectSingleNode("//div[@class='ebook-file-info']/span[5]").InnerText;
                            libro._totalDescargas = doc.DocumentNode.SelectSingleNode("//div[@class='ebook-file-info']/span[7]").InnerText;
                            libro._idioma = doc.DocumentNode.SelectSingleNode("//div[@class='ebook-file-info']/span[9]").InnerText;
                            libro._categoria = _categorias;


                            info.infoID=libroID;
                            string dir = _dir+e.ToString();
                            info._urlCategoria = dir;
                            var _enlaceLibro = doc.DocumentNode.SelectNodes("//div[@class='ebook-left']/a[@href]").Select(a=>a.Attributes["href"].Value);
                            foreach(var en in _enlaceLibro)
                                    info._urlLibro=("https://es.pdfdrive.com"+en.ToString());
                                    
                            string _author="";
                            var _autor = doc.DocumentNode.SelectNodes("//div[@class='ebook-author']/a/span");
                            if(_autor is not null){
                                foreach(var a in _autor){
                                    _author+=(a.InnerText+" ");
                                } 
                                info._autores =_author;         
                            }else{
                                info._autores="sin autor";
                            }

                            WriteLine("\n ****** Libro ****** "+libro.ToString());
                            WriteLine("\n ****** Informacion ****** "+info.ToString());
                                    
                            libros.Add(libro);
                            informacion.Add(info);
                            dir = _dir;
                            
                        }
                        WriteLine("\n");
                   }
                }

                //llenamos los datos recolectados dentro de la base de datos.
                foreach(var l in libros)
                    db.Add(l);
                
                foreach(var i in informacion)
                    db.Add(i);
                
                db.SaveChanges();  


                //CONSULTAS
                WriteLine("\t\t\t CONSULTAS: \n");

                WriteLine("Consulta 1: Obtener todos los libros");
                var booksTot = db.libros.ToList();
                booksTot.ForEach(b=>WriteLine(b.ToString()));
                WriteLine("\n Total: "+booksTot.Count);

                WriteLine("\n\nConsulta 2: Obtener los libros en donde su ano de publicacion es 2008");
                var yearBooks = db.libros.Where(a=>a._fechaPublicacion.Equals("2008")).ToList();
                yearBooks.ForEach(b=>WriteLine(b.ToString()));
                WriteLine("\n Total: "+yearBooks.Count);
    
                 WriteLine("\n\nConsulta 3: Obtener todos los libros que empiecen con m");
                var initBooks= db.libros.Where(c=>c._nombreLibro.StartsWith("E")).ToList();
                initBooks.ForEach(b=>WriteLine(b.ToString()));
                WriteLine("\n Total: "+initBooks.Count);


                WriteLine("\n\nConsulta: 4: Obtener los libros en donde tengan 324 paginas");
                var autorBooks = db.libros.Where(a=>a._paginas.Equals("324 Páginas")).ToList();
                autorBooks.ForEach(b=>WriteLine(b.ToString()));
                WriteLine("\n Total: "+autorBooks.Count);



        }
    }
}