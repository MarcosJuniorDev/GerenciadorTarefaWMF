using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenTarefa
{
    public partial class NovaLista : Form
    {
        string FILE_NAME = "save.Data";
        public NovaLista()
        {
            InitializeComponent();
        }

        private void NovaLista_Load(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameContent.Text;
            string desc = conteudoList.Text;
            
            if (!File.Exists(FILE_NAME))
            {
                using (FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(name);
                        sw.WriteLine(desc);
                    }
                }
            }
            else
            {
                using (StreamWriter fs = new StreamWriter(FILE_NAME, true))
                {
                    fs.WriteLine(name);
                    fs.WriteLine(desc);
                }
            }
            nameContent.Text = "";
            conteudoList.Text = "";
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
