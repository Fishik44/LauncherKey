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
    public partial class Form2 : Form
    {
        private Form active;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PanelForm(new Game());
        }

        private void PanelForm(Form fm)
        {
            if (active != null)
                active.Close();

            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.BringToFront();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelForm(new Settings1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelForm(new Game());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelForm(new Inject());
        }
    }
}
