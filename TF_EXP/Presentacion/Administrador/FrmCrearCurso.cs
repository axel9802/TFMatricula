using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class FrmCrearCurso : Form
    {
        public nCurso geCur = new nCurso();
        public eCurso curso = null;

        public FrmCrearCurso()
        {
            InitializeComponent();
        }

        private bool CodigoExiste(int cod)
        {
            return geCur.ListarCurso().Exists(delegate (eCurso value)
            {
                return value.Codigo == cod;
            });
        }

        private bool NombreExiste(string nom)
        {
            return geCur.ListarCurso().Exists(delegate (eCurso value)
            {
                return value.Nombre == nom;
            });
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(txtCodigo.Text);
                string nom = txtNombre.Text;
                int vac = int.Parse(numVacante.Value.ToString());

                if (nom != "")
                {
                    if (cod < 999 && cod > 100)
                    {
                        if (!CodigoExiste(cod))
                        {
                            if (!NombreExiste(nom))
                            {

                                curso = new eCurso();
                                curso.Codigo = cod;
                                curso.Nombre = nom;
                                curso.Vacante = vac;
                                geCur.RegistrarCurso(curso);
                                MessageBox.Show("Curso registrado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                                listarCurso();

                            }
                            else
                            {
                                MessageBox.Show("El nombre del curso ingresado ya existe, por favor ingrese uno válido", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El código ingresado le pertenece a otro curso, por favor ingrese un nombre válido", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Código inválido, intente ingresando otro", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Complete los datos", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Complete los campos, por favor", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            numVacante.Value = 10;
        }

        private void FrmCrearCurso_Load(object sender, EventArgs e)
        {
            listarCurso();
        }

        private void listarCurso()
        {
            dgCurso.DataSource = geCur.ListarCurso();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listarCurso();
            txtCodigo.Focus();
        }

        private void dgCurso_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = dgCurso.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text= dgCurso.CurrentRow.Cells[1].Value.ToString();
            numVacante.Value= int.Parse(dgCurso.CurrentRow.Cells[2].Value.ToString());
            txtCodigo.Enabled = false;
            numVacante.Enabled = false;
        }

        private void Habilitar()
        {
            txtCodigo.Enabled = true;
            numVacante.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(txtCodigo.Text);
                string nom = txtNombre.Text;

                if (nom != "")
                {
                    if (!NombreExiste(nom))
                    {
                        curso = new eCurso();
                        curso.Codigo = cod;
                        curso.Nombre = nom;
                        geCur.ModificarCurso(curso);
                        MessageBox.Show("Datos del curso modificado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listarCurso();
                        Limpiar();
                        Habilitar();
                    }
                    else
                    {
                        MessageBox.Show("El nombre del curso ingresado ya existe, por favor ingrese uno válido", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        Limpiar();
                        Habilitar();
                    }
                }
                else
                {
                    MessageBox.Show("Complete los datos", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un curso", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(txtCodigo.Text);
                
                geCur.EliminarCurso(cod);
                MessageBox.Show("Curso eliminado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listarCurso();
                Limpiar();
                Habilitar();
            }
            catch(Exception)
            {
                MessageBox.Show("Seleccione un curso", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Formato incorrecto, por favor ingrese solo números", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}