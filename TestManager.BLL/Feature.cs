using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManager.Model;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestManager.BLL
{
    public class Feature
    {
        public Dictionary<Funcionalidade, List<Cenario>> ImportarPlanilha(string caminho)
        {
            Arquivo arquivo = new Arquivo();

            arquivo.ImportarPlanilha(caminho);
            arquivo.Dispose();

            return new Dictionary<Funcionalidade, List<Cenario>>();
        }
    }
}
