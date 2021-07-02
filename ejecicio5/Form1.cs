using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejecicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[Convert.ToInt32(txt_n.Text), Convert.ToInt32(txt_m.Text)];
            Random matrizaleatoria = new Random();

            for (int fila = 0; fila < matriz.GetLength(0) ; fila++)
            {
                for (int col=0; col < matriz.GetLength(1); col++)
                {
                    matriz[fila, col] = matrizaleatoria.Next(0, 100);
                    MessageBox.Show("la posicion es:" + fila + "," + col + "=" + matriz[fila, col].ToString());
                }
            }

        }
    }
}
