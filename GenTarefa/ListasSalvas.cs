using GenTarefa.Entities;
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
    

    public partial class ListasSalvas : Form
    {      
        
        private const string FILE_NAME = "save.Data";
        public ListasSalvas()
        {
            InitializeComponent();

        }

        private void ListasSalvas_Load(object sender, EventArgs e)
        {
            
            List<Tarefas> listaT = LerDados();
            gridTarefas.DataSource = listaT;
            
            
        }

        static List<Tarefas> LerDados()
        {
            List<Tarefas> listaTarefa = new List<Tarefas>();
            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                while (!sr.EndOfStream)
                {
                    Tarefas tarefas = new Tarefas();
                    tarefas.Name = sr.ReadLine();
                    tarefas.Descricao = sr.ReadLine();
                    listaTarefa.Add(tarefas);

                }
            }
            return listaTarefa;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = gridTarefas.CurrentRow.Cells["Name"].Value.ToString();
            descBox.Text = gridTarefas.CurrentRow.Cells["Descricao"].Value.ToString();
           
        }
    }
}
