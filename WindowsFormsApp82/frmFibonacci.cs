using System;
using System.Windows.Forms;

namespace WindowsFormsApp82
{
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();
        }

        private int[] fibonacci;
        private void okButton_Click(object sender, EventArgs e)
        {
            int cantidad = (int)nNumericUpDown.Value;
            fibonacci = new int[cantidad];
            GenerarTerminos();
            MostrarTerminos();
        }

        private void MostrarTerminos()
        {
            fibonacciListBox.Items.Clear();
            foreach (var termino in fibonacci)
            {
                fibonacciListBox.Items.Add(termino.ToString().PadLeft(6,'0'));
            }
        }

        private void GenerarTerminos()
        {
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            if (fibonacci.Length > 2)
            {
                for (int i = 2; i < fibonacci.Length; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }

            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            nNumericUpDown.Value = 2;
            nNumericUpDown.Focus();
        }

        private void reiniciarButton_Click(object sender, EventArgs e)
        {
            fibonacciListBox.Items.Clear();
            InicializarControles();
        }

        private void frmFibonacci_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir del programa?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
