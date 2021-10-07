using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laucher
{
    public partial class Reg : Form
    {
        static string name = "Laucher";
        static string owner = "hs9gVJvlEN";
        static string secret = "c39df9315e58159b103379d3616fe1a0943887025bbe90726f57e2c79d05e4b1";
        static string ver = "1.0";

        public static api KeyAuthApi = new api(name, owner, secret, ver);
        public Reg()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KeyAuthApi.register(textBox1.Text, textBox2.Text, textBox3.Text))
            {
                MessageBox.Show("Вы успешно загеристировались");
                this.Hide();
            }
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            KeyAuthApi.init();
        }
    }
}
