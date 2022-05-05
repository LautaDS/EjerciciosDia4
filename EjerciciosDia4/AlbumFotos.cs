namespace EjerciciosDia4
{
    #region classes

    class AlbumFotos
    {
        private int numPaginas;

        
        public AlbumFotos()
        {
            this.numPaginas = 16;
        }
        public AlbumFotos(int numPaginas)
        {
            this.numPaginas = numPaginas;
        }

        public int NumPaginas { get => numPaginas; set => numPaginas = value; }




    }

    #endregion

}
