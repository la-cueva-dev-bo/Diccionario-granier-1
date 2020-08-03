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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String palabra = listBox1.SelectedItem.ToString();

            
                listBox2.Items.Clear();
                listBox2.Items.Add(palabra+" [tipo de palabra]");
                listBox2.Items.Add("Descripcion palabra o intervalos");
                listBox2.Items.Add("detalle palabra");
                listBox2.Items.Add("");
                listBox2.Items.Add(palabra + " [propiedades]");
                listBox2.Items.Add("");
                listBox2.Items.Add("SINÖNIMOS");
                listBox2.Items.Add("    - cantidad de sinonimos");



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
