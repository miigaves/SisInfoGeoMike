using Microsoft.EntityFrameworkCore;

namespace TercerExamenParcial{

    public class DataContext: DbContext{


            private static bool _creada = false;
            public DbSet<Libro> libros {get;set;}
            public DbSet<Info> informacion {get;set;}
        	//public DbSet<Categoria> categorias {get;set;}
            //public DbSet<Libro> libros {get;set;}


            public DataContext(){
                if(!_creada){
                    _creada = true;
                    Database.EnsureDeleted();
                    Database.EnsureCreated(); 
                }
            }
            protected override void OnConfiguring(DbContextOptionsBuilder opciones){
                opciones.UseSqlite(@"Data Source=Catalogo.db");
            }
    }
}