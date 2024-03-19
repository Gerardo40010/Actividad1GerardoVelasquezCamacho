using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CrudBasico.Modelos;
using CrudBasico.BSS;
using CrudBasico.DAL;
namespace CrudBasico.VISTA.ComputadoraVistas
{
    public partial class ComputadoraEditarVista : Form
    {
        int idx = 0;
        Computadora computadora = new Computadora();
        ComputadoraBss bss = new ComputadoraBss();
        public ComputadoraEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ComputadoraEditarVista_Load(object sender, EventArgs e)
        {
            computadora = bss.ObtenerComputadoraIdBss(idx);
            textBox1.Text = computadora.Nombre.ToString();
            textBox2.Text = computadora.Descripcion.ToString();
            textBox3.Text = computadora.Precio.ToString();
            dateTimePicker1.Value = computadora.FechaFabricacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            computadora.Nombre =(textBox1.Text);
            computadora.Descripcion=textBox2.Text;
            computadora.FechaFabricacion = dateTimePicker1.Value;
            computadora.Precio = int.Parse(textBox3.Text);
           
            bss.EditarComputadoraBss(computadora);
            MessageBox.Show("Detalle de ingreso actualizado correctamente.");
        }
    }
}
