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

            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                while (!sr.EndOfStream)
                {
                    string[] campos = sr.ReadLine().Split(";");
                    string name = campos[0];
                    gridTarefas.Rows.Add(name);
                }
                
                
                
            }
            
            //gridTarefas.Columns[1].Visible = false;
            
            
        }

        static List<Tarefas> LerDados()
        {
            List<Tarefas> listaTarefa = new List<Tarefas>();
            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                while (!sr.EndOfStream)
                {
                    Tarefas tarefas = new Tarefas();
                    string[] vet = sr.ReadLine().Split(";");
                    tarefas.Name = vet[0];
                    tarefas.Descricao = vet[1];
                    listaTarefa.Add(tarefas);

                }
            }
            return listaTarefa;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (gridTarefas.CurrentRow != null)
            {
                using (StreamReader sr = new StreamReader(FILE_NAME))
                {
                    List<Tarefas> tarefas = LerDados();
                    Tarefas tarefaLoad = tarefas.Find(x => x.Name == gridTarefas.CurrentRow.Cells["Nome"].Value.ToString());                    
                    if (tarefaLoad != null)
                    {
                        nameBox.Text = tarefaLoad.Name;
                        descBox.Text = tarefaLoad.Descricao;
                    }
                }


                //nameBox.Text = gridTarefas.CurrentRow.Cells["Name"].Value.ToString();
                //descBox.Text = gridTarefas.CurrentRow.Cells["Descricao"].Value.ToString();
            }
            
           
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridTarefas.CurrentRow != null)
                {
                    string msg = "Tem certeza que deseja excluir essa tarefa?";
                    string titulo = "Deletar Nota";
                    var result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        List<Tarefas> tarefas = LerDados();

                        Tarefas nomeRemover = tarefas.Find(x => x.Name == gridTarefas.CurrentRow.Cells["Nome"].Value.ToString());

                        if (nomeRemover != null)
                        {
                            tarefas.Remove(nomeRemover);
                        }

                        using (StreamWriter sw = new StreamWriter(FILE_NAME))
                        {
                            foreach (Tarefas list in tarefas)
                            {
                                sw.WriteLine($"{list.Name};{list.Descricao}");
                            }
                        }
                        gridTarefas.DataSource = tarefas;
                        nameBox.Text = "";
                        descBox.Text = "";
                    }
                    
                    
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
