using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_EF.Logica;
using Test_EF.Beans;

namespace Test_EF
{
    public partial class frmGuardarUsuario : Form
    {
        private frmUsuarios frmBase;
        private int id;
        UsuarioLogica ul = new UsuarioLogica();

        public frmGuardarUsuario(int id, frmUsuarios frmPadre) : base(){
            InitializeComponent();
            this.id = id;
            this.frmBase = frmPadre;

            this.txtID.Text = id.ToString();

            if(id > 0)
            {
                UsuarioBean ub = ul.GetUsuario(id);
                this.txtUsuario.Text = ub.Usuario;
                this.txtContrasena.Text = ub.Password;
            }
        }

        public frmGuardarUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmGuardarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            UsuarioBean ub = new UsuarioBean();
            ub.Id = Convert.ToInt32(this.txtID.Text);
            ub.Usuario = this.txtUsuario.Text;
            ub.Password = this.txtContrasena.Text;

            ul.Guardar(ub);

            this.frmBase.UpdateGrid();
            this.Close();
        }
    }
}
