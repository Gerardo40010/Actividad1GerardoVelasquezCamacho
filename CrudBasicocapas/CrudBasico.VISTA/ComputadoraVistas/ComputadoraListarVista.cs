using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudBasico.BSS;
namespace CrudBasico.VISTA.ComputadoraVistas
{
    public partial class ComputadoraListarVista : Form
    {
        public ComputadoraListarVista()
        {
            InitializeComponent();
        }
        ComputadoraBss bss = new ComputadoraBss();
        private void ComputadoraListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarComputadoraBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComputadoraInsertarVista fr = new ComputadoraInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdComputadoraSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ComputadoraEditarVista fr = new ComputadoraEditarVista(IdComputadoraSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdComputadoraSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Estas seguro de eliminar esta  persona", "Eliminado", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarComputadoraBss(IdComputadoraSeleccionada);
                dataGridView1.DataSource = bss.ListarComputadoraBss();
            }
        }
    }
}
