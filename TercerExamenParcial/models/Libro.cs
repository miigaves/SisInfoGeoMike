namespace TercerExamenParcial{
    public class Libro{
        
        public int libroID{get;set;}
        public string _nombreLibro {get;set;}
        public string _paginas {get;set;}
        public string _fechaPublicacion{get;set;}
        public string _peso {get;set;}
        public string _totalDescargas{get;set;}
        public string _idioma {get;set;}
        public string _categoria{get;set;}

        public override string ToString(){
            return "\nID: "+libroID.ToString()+ "\nNombre del Libro: "+_nombreLibro +"\nNumero de Paginas: "+_paginas+
            "\nAno de publicacion: "+_fechaPublicacion+"\nPeso: "+_peso+"\nTotal de descargas: "+_totalDescargas+
            "\nIdioma: "+_idioma+"\nCategoria: "+_categoria;
        }

        

    }
}