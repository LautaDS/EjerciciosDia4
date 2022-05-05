using System;
namespace EjerciciosDia4
{
    #region classes


    class AlbumTest
    {
        AlbumFotos albumDefault = new AlbumFotos();
        SuperAlbumFotos albumSuper = new SuperAlbumFotos();
        AlbumFotos album = new AlbumFotos();

        public AlbumTest (int fotosAlbum)
        {
            this.album.NumPaginas = fotosAlbum;
        }

        public void Mostrar()
        {
            Console.WriteLine("El album default tiene " + albumDefault.NumPaginas + " paginas");
            Console.WriteLine("El album super tiene " + albumSuper.NumPaginas + " paginas");
            Console.WriteLine("Y el album que ingreso tiene " + album.NumPaginas + " paginas" );
        }
    }

    #endregion

}
