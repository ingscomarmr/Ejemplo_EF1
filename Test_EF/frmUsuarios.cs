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

namespace Test_EF
{
    public partial class frmUsuarios : Form
    {

        private UsuarioLogica logica = new UsuarioLogica();
        private int id = 0;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        public void UpdateGrid() {
            dgvUsuarios.DataSource = logica.GetUsuarios();
        }

        private void ShowDelete() {
            if(this.id > 0)
            {
                this.btnEliminar.Visible = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.id > 0) {
                
                DialogResult dr = MessageBox.Show(
                    "Eliminar el registro Id:" + this.id,
                    "Eliminar",
                    MessageBoxButtons.OKCancel
                    );

                if (dr == DialogResult.OK) {
                    logica.Eliminar(this.id);
                    this.id = 0;
                    this.btnEliminar.Visible = false;
                }                                
            }
            UpdateGrid();            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            new frmGuardarUsuario(0, this).ShowDialog();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value);
            this.Visible = true;
            ShowDelete();
        }

        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.id = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value);
                new frmGuardarUsuario(id, this).ShowDialog();
                ShowDelete();
            }
        }
    }
}
