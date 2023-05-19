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
            if (gridTarefas.CurrentRow != null)
            {
                nameBox.Text = gridTarefas.CurrentRow.Cells["Name"].Value.ToString();
                descBox.Text = gridTarefas.CurrentRow.Cells["Descricao"].Value.ToString();
            }
            
           
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridTarefas.CurrentRow != null)
                {
                    List<Tarefas> tarefas = LerDados();

                    Tarefas nomeRemover = tarefas.Find(x => x.Name == gridTarefas.CurrentRow.Cells["Name"].Value.ToString());

                    if (nomeRemover != null)
                    {
                        tarefas.Remove(nomeRemover);
                    }

                    using (StreamWriter sw = new StreamWriter(FILE_NAME))
                    {
                        foreach (Tarefas list in tarefas)
                        {
                            sw.WriteLine(list.Name);
                            sw.WriteLine(list.Descricao);
                        }
                    }
                    gridTarefas.DataSource = tarefas;
                    nameBox.Text = "";
                    descBox.Text = "";

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro");
            }
        }
    }
}
