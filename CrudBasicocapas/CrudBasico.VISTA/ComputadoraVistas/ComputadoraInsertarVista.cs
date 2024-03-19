using CrudBasico.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudBasico.Modelos;
using CrudBasico.DAL;
namespace CrudBasico.VISTA
{
    public partial class ComputadoraInsertarVista : Form
    {
        ComputadoraBss bss = new ComputadoraBss();
        public ComputadoraInsertarVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Computadora computadora = new Computadora();
            computadora.Nombre = textBox1.Text;
            computadora.Descripcion = textBox2.Text;
            computadora.Precio = int.Parse(textBox3.Text);
            computadora.FechaFabricacion = dateTimePicker1.Value;
            bss.InsertarComputadoraBss(computadora);
            MessageBox.Show("Se guardo correctamente la persona");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* ComputadoraListarVista fr = new ComputadoraListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Computadora computadora = bss.ObtenerComputadoraIdBss(IdComputadoraSeleccionada);
                textBox1.Text = computadora.Nombre;

            }*/
        }
    }
}
