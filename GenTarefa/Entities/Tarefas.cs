using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenTarefa.Entities
{
    internal class Tarefas
    {
        public string Name { get; set; }
        public string Descricao { get; set; }

        public Tarefas()
        {
        }
        
        public Tarefas(string name, string descricao)
        {
            Name = name;
            Descricao = descricao;
        }
    }
}
