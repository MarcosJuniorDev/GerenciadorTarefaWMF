using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenTarefa.Entities;

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
            Tarefas tarefas = new Tarefas(name, desc);
            List<Tarefas> tarefasList = new List<Tarefas>();
            tarefasList.Add(tarefas);    

            
            if (!File.Exists(FILE_NAME))
            {
                using (FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine($"{tarefas.Name};{tarefas.Descricao}");
                    }
                }
            }
            else
            {
                using (StreamWriter fs = new StreamWriter(FILE_NAME, true))
                {
                    fs.WriteLine($"{tarefas.Name};{tarefas.Descricao}");
                }
            }
            nameContent.Text = "";
            conteudoList.Text = "";
            var result = MessageBox.Show("Tarefa criada com sucesso");
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
