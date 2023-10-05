using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakas
{
    public partial class FormIntro : Form
    {
        public FormIntro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(0, Convert.ToInt32(txtHamleSayisi.Text));
            form.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(1, Convert.ToInt32(txtHamleSayisi.Text));
            form.Show(this);
            this.Hide();
        }

        private void FormIntro_Load(object sender, EventArgs e)
        {

        }
    }
}
