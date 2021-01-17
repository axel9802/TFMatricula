using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class FrmAsignarProfe : Form
    {
        public nCurso geCur = new nCurso();
        public eUsuario user = new eUsuario();
        public nUsuario geUser = new nUsuario();
        public eMatricula mat = null;
        public nMatricula geMat = new nMatricula();

        public FrmAsignarProfe()
        {
            InitializeComponent();
        }

        private void AsignarCursos_Load(object sender, EventArgs e)
        {
            listaCursos.DisplayMember = "Nombre";
            listaCursos.ValueMember = "Codigo";
            listaCursos.DataSource = geCur.ListarCurso();
            listaCursos.SelectedIndex = -1;

            cmBoxProfesor.DisplayMember = "Nombre"+"Apellido";
            cmBoxProfesor.ValueMember = "Codigo";
            cmBoxProfesor.DataSource = geUser.listarProfes();
            cmBoxProfesor.SelectedIndex = -1;
        }

        private bool CursoExiste(int cod)
        {
            return geMat.DatosMatriculaUsuario().Exists(delegate (eMatricula value)
            {
                return value.CodCurso == cod;
            });
        }

        private bool UsuarioExiste(int cod)
        {
            return geMat.DatosMatriculaUsuario().Exists(delegate (eMatricula value)
            {
                return value.CodUsuario == cod;
            });
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int codUser = int.Parse(cmBoxProfesor.SelectedValue.ToString());
                int codCurso = int.Parse(listaCursos.SelectedValue.ToString());
                string curso = listaCursos.SelectedItem.ToString();
                int cur = int.Parse(geUser.DatosUsuario(codUser).Cursos.ToString());

                if (!CursoExiste(codCurso) || !UsuarioExiste(codUser))
                {
                    mat = new eMatricula();

                    foreach (eCurso c in listaCursos.SelectedItems)
                    {
                        if (cur < 3)
                        {
                            c.Codigo = codCurso;
                            c.Nombre = curso;
                            user.Codigo = codUser;
                            geMat.RegistarMatricula(codCurso, codUser, curso);
                            MessageBox.Show("Asignación satisfactoria", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Límite de cursos alcanzado", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El profesor ya se encuentra asignado en este curso", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Elija los datos requeridos", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}