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
    public partial class UltimoPasso : Form
    {
        public UltimoPasso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var bus = new Buscar();
            bus.ShowDialog();
            Application.Exit();
        }
    }
}
