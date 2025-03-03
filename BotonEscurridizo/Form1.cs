using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotonEscurridizo
{
    public partial class Form1: Form
    {
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            btnEscurridizo.MouseEnter += btnEscurridizo_MouseEnter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEscurridizo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea formatear su dispositivo","", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void btnEscurridizo_MouseEnter(object sender, EventArgs e)
        {
            MoverBoton();
        }

        private void MoverBoton()
        {
            int maxX = this.ClientSize.Width - btnEscurridizo.Width;
            int maxY = this.ClientSize.Height - btnEscurridizo.Height;

            int randomX = rand.Next(0, maxX);
            int randomY = rand.Next(0, maxY);

            btnEscurridizo.Location = new Point(randomX, randomY);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
