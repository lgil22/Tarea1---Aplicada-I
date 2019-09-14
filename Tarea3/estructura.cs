using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAP2.Tarea3
{
    public partial class estructura : Form
    {
        public estructura()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            ProductocomboBox.Items.Add(ProductoNewtextBox.Text);
            ProductoNewtextBox.Clear();
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombretextBox1.Text = ProductocomboBox.Text;
     
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ProductocomboBox.Items.Remove(NombretextBox1);
            NombretextBox1.Clear();

        }

        private void Salirbutton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
