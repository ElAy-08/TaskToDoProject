using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToDo.Pasta_Classes
{
    public class Funcionario
    {
        //Um funcionário tem um nome
        public string Nome { get; set; }
        //Um funcionário tem várias tarefas
        public List<Tarefa> Tarefas = new List<Tarefa>();

        //Override do ToString para mostrar o nome do funcionário na TreeView e ComboBox
        public override string ToString() => Nome;

    }
}
