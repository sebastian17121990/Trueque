namespace truequeApp
{
    internal class Usuario
    {
        public string rut;
        public string nombre;

        public List<Articulo> articulos = new List<Articulo>();
        public Usuario(string rut, string nombre)
        {
            this.rut = rut;
            this.nombre = nombre;
        }

        public string getRut()
        {
            return this.rut;
        }

        private void setRut(string rut)
        {
            this.rut = rut;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        private void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
