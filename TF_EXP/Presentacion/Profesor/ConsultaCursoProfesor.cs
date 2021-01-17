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
    public partial class ConsultaCursoProfesor : Form
    {
        public eUsuario user = new eUsuario();
        public nMatricula geMat = new nMatricula();

        public ConsultaCursoProfesor()
        {
            InitializeComponent();
        }

        public ConsultaCursoProfesor(eUsuario u)
        {
            InitializeComponent();
            user = u;
        }

        private void ConsultaCursoProfesor_Load(object sender, EventArgs e)
        {
            dgCursos.DataSource = geMat.DatosMatriculados(user.Codigo);
        }
    }
}