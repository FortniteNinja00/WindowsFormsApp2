using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int licznik = 0;
        private int dodawanie = 1;  
        private int czas = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            licznik = licznik + dodawanie;
            label1.Text = licznik.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czas == 0)
            {
                timer1.Stop();
                dodawanie = 0;
                label3.Text = (licznik/10).ToString() + " kliknięć na sekundę";

            }
            else if (czas > 0)
            {
                czas--;
                label2.Text = czas.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
