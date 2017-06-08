using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MestreEstudos
{
    public partial class Identificar : Form
    {
        public Identificar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var des = new Descrever();
            des.ShowDialog();
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ult = new UltimoPasso();
            ult.ShowDialog();
            Application.Exit();
        }
    }
}
