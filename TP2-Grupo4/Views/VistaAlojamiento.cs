using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TP2_Grupo4.Models;
using TP2_Grupo4;

namespace TP2_Grupo4.Views
{
    public partial class VistaAlojamiento : Form
    {
        AgenciaManager agencia = new AgenciaManager();
        public VistaAlojamiento()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        // TODO: Añadir filtros

        // TODO: Cambiar Ciudad, Barrio, Estrellas y Personas por COMBOBOX
        // TODO: Cambiar TV por CHECKBOX
        private void FormAlojamiento_Load(object sender, EventArgs e)
        {
            // Boton borrar
            var btnBorrar = new DataGridViewButtonColumn
            {
                Text = "BORRAR",
                UseColumnTextForButtonValue = true,
                Name = "BORRAR",
                DataPropertyName = "BORRAR",
                FlatStyle = FlatStyle.Flat,
            };
            btnBorrar.DefaultCellStyle.BackColor = Color.IndianRed;

            // Boton modificar
            var btnModificar = new DataGridViewButtonColumn
            {
                Text = "MODIFICAR",
                UseColumnTextForButtonValue = true,
                Name = "MODIFICAR",
                DataPropertyName = "MODIFICAR",
                FlatStyle = FlatStyle.Flat,
            };
            btnModificar.DefaultCellStyle.BackColor = Color.LightYellow;
            table.Columns.Add("Codigo", typeof(int));
            table.Columns.Add("Ciudad", typeof(string));
            table.Columns.Add("Barrio", typeof(string));
            table.Columns.Add("Estrellas", typeof(int));
            table.Columns.Add("Cant. Personas", typeof(int));
            table.Columns.Add("TV", typeof(bool));
            table.Columns.Add("Precio", typeof(double));
            dgvAlojamiento.DataSource = table;


            dgvAlojamiento.Columns.Add(btnModificar);
            dgvAlojamiento.Columns.Add(btnBorrar);
            /*table.Columns.Add("Codigo", typeof(int));
            table.Columns.Add("Ciudad", typeof(string));
            table.Columns.Add("Barrio", typeof(string));
            table.Columns.Add("Estrellas", typeof(int));
            table.Columns.Add("Cant. Personas", typeof(int));
            table.Columns.Add("TV", typeof(bool));
            table.Columns.Add("Precio", typeof(double));
            table.Columns.Add("Habitaciones", typeof(int));
            table.Columns.Add("Baños", typeof(int));*/

            dgvAlojamiento.ReadOnly = false;
            getTextAlojamientos();
        }

        private void getTextAlojamientos()
        {
            List<Alojamiento> alojamientos = this.agencia.GetAgencia().GetAllAlojamientos();
            foreach (Alojamiento alojamiento in alojamientos)
            {
                this.table.Rows.Add(
                    alojamiento.GetCodigo(),
                    alojamiento.GetCiudad(),
                    alojamiento.GetBarrio(),
                    alojamiento.GetEstrellas(),
                    alojamiento.GetCantidadDePersonas(),
                    alojamiento.GetTv(),
                    alojamiento.PrecioTotalDelAlojamiento()
                );
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Int32.Parse(txtCodigo.Text);
            string ciudad = txtCiudad.Text;
            string barrio = txtBarrio.Text;
            int estrellas = Int32.Parse(comboBoxEstrellas.Text);
            int cantidadPersonas = Int32.Parse(comboBoxCantPersonas.Text);
            bool tv = checkBoxTv.Checked;
            double precio = double.Parse(txtPrecio.Text);




            if ((comboBoxTipoAloj.SelectedItem).ToString() == "Hotel")
            {
                Hotel h = new Hotel(codigo, ciudad, barrio, estrellas, cantidadPersonas, tv, precio);
                //a1.AgregarAlojamiento(h);
                agencia.GetAgencia().AgregarAlojamiento(h);
            }
            else
            {
                Cabania c = new Cabania(codigo, ciudad, barrio, estrellas, cantidadPersonas, tv, precio, 1, 1);
                //a1.AgregarAlojamiento(c);
                agencia.GetAgencia().AgregarAlojamiento(c);
            }

            this.agencia.GetAgencia().GuardarCambiosEnElArchivo();
            clearAllControls();
            getAlojamientosFromTextFile();

            /*this.agencia.AgregarUsuario(dni, nombre, email, password, isadmin, bloqueado);
            this.agencia.GuardarCambiosDeLosUsuarios();
            clearAllControls();
            getUsuariosFromTextFile();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*btnAgregar.Visible = true;
            btnTopModificar.Visible = false;

            var dni = Int32.Parse(txtDni.Text);
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            bool bloqueado = checkBoxBloqueado.Checked;


            this.agencia.ModificarUsuario(dni, nombre, email, password);

            if (!bloqueado)
            {
                this.agencia.DesbloquearUsuario(dni);
            }
            else
            {
                this.agencia.BloquearUsuario(dni);
            }


            this.agencia.GuardarCambiosDeLosUsuarios();

            clearAllControls();
            getUsuariosFromTextFile();*/
        }

        private void comboBoxTipoAloj_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comboBoxTipoAloj.Items.Count == 2)
            {
                comboBoxTipoAloj.Items.Insert(0, "Todos");
            }*/
        }

        private void comboBoxEstrellas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEstrellas.Items.Count == 4)
            {
                comboBoxEstrellas.Items.Insert(0, "1");
            }
        }

        private void comboBoxCantPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCantPersonas.Items.Count == 9)
            {
                comboBoxCantPersonas.Items.Insert(0, "1");
            }
        }

        #region Helper
        /*private void rellenarDatos()
        {
            txtDni.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtPassword.Text = "";
            checkBoxAdmin.Checked = bool.Parse(dgvUsuarios.CurrentRow.Cells[4].Value.ToString());
            checkBoxAdmin.Enabled = false;
            checkBoxBloqueado.Checked = bool.Parse(dgvUsuarios.CurrentRow.Cells[5].Value.ToString());
        }*/

        // Resetear campos
        private void clearAllControls()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;

                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;

                    comboBox.Text = "";
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
            }
        }

        private void getAlojamientosFromTextFile()
        {
            // Limpiamos el GridView
            dgvAlojamiento.Rows.Clear();

            List<Alojamiento> alojamientos = this.agencia.GetAgencia().GetAllAlojamientos();

            foreach (Alojamiento alojamiento in alojamientos)
            {
                this.dgvAlojamiento.Rows.Add(
                    alojamiento.GetCodigo(),
                    alojamiento.GetCiudad(),
                    alojamiento.GetBarrio(),
                    alojamiento.GetEstrellas(),
                    alojamiento.GetCantidadDePersonas(),
                    alojamiento.GetTv(),
                    alojamiento.PrecioTotalDelAlojamiento()
                );
            }

            // Update y Regresheo de Grid
            dgvAlojamiento.Update();
            dgvAlojamiento.Refresh();
        }

        #endregion
    }
}
