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
        public async Task<List<Funcionalidade>> ImportarPlanilha(string caminho)
        {
            try
            {
                Arquivo arquivo = new Arquivo();

                List<Funcionalidade> funcionalidades = arquivo.ImportarPlanilha(caminho);
                arquivo.Dispose();

                return funcionalidades;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> ExportarPlanilha(List<Funcionalidade> funcionalidades)
        {
            try
            {
                Arquivo arquivo = new Arquivo();

                foreach (Funcionalidade funcionalidade in funcionalidades)
                {
                    arquivo.ExportarArquivo(funcionalidade);
                }

                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
