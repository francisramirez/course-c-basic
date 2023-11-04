namespace claseBasica.ContactForm.Class
{
    /// <summary>
    /// Objeto creado para el acceso a los datos del formulario de contactos.
    /// </summary>
    public class ContactDao
    {
        private List<Contact> contacts;

        public ContactDao()
        {
            this.contacts = new List<Contact>();
        }

        /// <summary>
        /// Metodo para guardar un contacto
        /// </summary>
        /// <param name="contact">Contacto que desea guardar</param>
        public void Guadar(Contact contact) 
        {
            if (contact == null)
                throw new ArgumentNullException("El contacto es requerido para ejecutar este metodo.");
            


            this.contacts.Add(contact);
        }

        /// <summary>
        /// Metodo para obtener todos los contactos
        /// </summary>
        /// <returns>Retorna una lista de los contactos</returns>
        public List<Contact> ObtenerContactos() 
        {
            return this.contacts;
        }

        /// <summary>
        /// Metodo para obtener los contactos por pais.
        /// </summary>
        /// <param name="pais">Pais que desea ver los contactos.</param>
        /// <returns>Retorna una lista de los contactos</returns>
        public List<Contact> ObtenerContactos(string pais) 
        {
             
            return this.contacts.Where(co => co.Pais == pais).ToList();
        }

        /// <summary>
        /// Obtener el detalle del contacto por la fecha de nacimiento
        /// </summary>
        /// <param name="fechaNac">fecha de nacimiento del contacto</param>
        /// <returns>Contacto encontrado a partir de la fecha de nacimiento</returns>
        public Contact ObtenerContacto(DateTime fechaNac)
        {
            Contact contact = this.contacts.FirstOrDefault(co => co.FechaNacimiento == fechaNac);
            return contact;
        }

        /// <summary>
        /// Metodo para obtener el detalle del contacto a partir del codigo.
        /// </summary>
        /// <param name="codigo">codigo del contacto que desea ver el detalle</param>
        /// <returns>Contacto encontrado a partir del codigo.</returns>
        public Contact ObtenerContacto(string codigo) 
        {
            return this.contacts.FirstOrDefault(co => co.Codigo == codigo);
        }

        protected Contact ObtenerDatos() 
        {
            Contact contact = this.contacts.First();
            return contact;
        }
    }
}
