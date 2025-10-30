using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToDo.Pasta_Classes
{
    public class Equipa
    {
        //Uma equipa tem um nome
        public string Nome { get; set; }
        //Uma equipa tem vários funcionários
        public List<Funcionario> Funcionarios = new List<Funcionario>();
        //Override do ToString para mostrar o nome da equipa na TreeView e ComboBox
        public override string ToString() => Nome;

    }
}
