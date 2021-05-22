namespace TercerExamenParcial{
    public class Info{

        public int infoID {get;set;}

        public string _urlLibro {get;set;}

        public string _urlCategoria{get;set;}

        public string _autores {get;set;}

        public override string ToString()
        {
            return  "\nID: "+ infoID+ "\nURL del libro: "+_urlLibro+"\nURL de la categoria: "+_urlCategoria+
            "\nAutores del Libro: "+_autores;
        }
    }
}