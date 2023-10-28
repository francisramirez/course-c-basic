namespace claseBasica.ContactForm.Class
{

    /// <summary>
    /// Clase para manejar los datos de los contactos.
    /// </summary>
    public class Contact
    {
     
        #region "atributos o campos de nuestra clase"
        private string _primerNombre;
        private string _segundoNombre;
        private string _apellidos;
        private string _correElectronico;
        private DateTime _fechaNacimiento;
        private string _puesto;
        private string _telefono;
        private string _paginaWeb;
        private string _notas;

        #endregion

        #region "Propiedades de la clase"

        /// <summary>
        /// Codigo de contacto
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Esta propiedad es para almacenar el primer del contacto.
        /// </summary>
        public string PrimerNombre
        {
            get { return _primerNombre; }
            set { _primerNombre = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar el segundo nombre del contacto.
        /// </summary>
        public string SegundoNombre
        {
            get { return _segundoNombre; }
            set { _segundoNombre = value; }
        }

        /// <summary>
        /// Esta propiedad es para almancer los apellidos del contacto.
        /// </summary>
        public string Apellido
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        /// <summary>
        /// Correo electronico del contacto. 
        /// </summary>
        public string CorreoElectronico
        {
            get { return _correElectronico; }
            set { _correElectronico = value; }

        }

        /// <summary>
        /// Fecha de nacimiento del contacto.
        /// </summary>
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        /// <summary>
        /// Puesto que desempeña el contacto.
        /// </summary>
        public string Puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }

        /// <summary>
        /// El telefono del contacto.
        /// </summary>
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        /// <summary>
        /// Pagina Web del Contacto.
        /// </summary>
        public string PaginaWeb 
        {
            get { return _paginaWeb; }
            set { _paginaWeb = value; }
        }
        /// <summary>
        /// Notas del contacto.
        /// </summary>
        public string Notas 
        {
            get { return _notas; }
            set { _notas = value;  }
        }

        /// <summary>
        /// Pais al que pertenece el contacto //
        /// </summary>
        public string? Pais { get; set; }


        /// <summary>
        /// Nombre completo del contacto.
        /// </summary>
        public string NombreCompleto 
        { 
            get { return string.Concat(this._primerNombre, " ", this._segundoNombre); } 
        }



        #endregion

    }
}
