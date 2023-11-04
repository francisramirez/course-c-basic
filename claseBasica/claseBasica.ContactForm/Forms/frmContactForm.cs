using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using claseBasica.ContactForm.Class;
using Vehicile.Class;
using Vehicile.Class.Objects;

namespace claseBasica.ContactForm.Forms
{
    public partial class frmContactForm : Form
    {
        ContactDao contactDao;
        public frmContactForm()
        {
            this.contactDao = new ContactDao();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact()
            {
                Apellido = tbxSegundoApellido.Text,
                CorreoElectronico = tbxCorreoElectronico.Text,
                PrimerNombre = tbxPrimerNombre.Text,
                FechaNacimiento = dtpFechaNac.Value,
                Notas = tbxNotas.Text,
                PaginaWeb = tbxPaginaWeb.Text,
                Codigo = tbxCodigo.Text,
                Pais = tbxPais.Text,
                Puesto = lblPuesto.Text,
                SegundoNombre = tbxSegundoApellido.Text,
                Telefono = tbxTelefono.Text
            };


            this.contactDao.Guadar(newContact);

            var contacs = this.contactDao.ObtenerContactos();

            Student student = new Student();

            this.dgvCotacts.DataSource = contacs.ToArray();
            this.dgvCotacts.Refresh();

            LimpiarCampos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            LimpiarCampos();
           
        }
        void LimpiarCampos() 
        {
            tbxSegundoApellido.Text = string.Empty;
            tbxCorreoElectronico.Text = string.Empty;
            tbxPrimerNombre.Text = string.Empty;
            dtpFechaNac.Value = DateTime.Now;
            tbxNotas.Text = string.Empty;
            tbxPaginaWeb.Text = string.Empty;
            tbxCodigo.Text = string.Empty;
            tbxPais.Text = string.Empty;
            tbxPuesto.Text = string.Empty;
            tbxSegundoApellido.Text = string.Empty;
            tbxTelefono.Text = string.Empty;
            tbxCodigo.Focus();
        }

        void GetDataVehiculo() 
        {
            //Vehiculo vehiculo = new Vehiculo();

            Jeep jeep = new Jeep() {  };

            // jeep.

            Car car = new Car() 
            {
                   
            };

           
        }
    }
}
