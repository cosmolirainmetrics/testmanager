using System.Collections.Generic;

namespace TestManager.Model
{
    public class Funcionalidade
    {
        public string Arquivo { get; set; }
        public string ID { get; set; }
        public string Descricao { get; set; }
        public string Eu { get; set; }
        public string Para { get; set; }
        public string Quero { get; set; }

        public List<Cenario> Cenarios = new List<Cenario>();
    }
}
