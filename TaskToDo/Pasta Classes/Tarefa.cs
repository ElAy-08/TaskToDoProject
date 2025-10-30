using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToDo.Pasta_Classes
{
    public class Tarefa
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        //Override do ToString para mostrar no formato nome da tarefa e as datas na TreeView
        public override string ToString()
        => $"{Nome} ({DataInicio:dd/MM/yyyy} - {DataFim:dd/MM/yyyy})";
    }
}
