using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TestManager.Model.Configuracao;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestManager.BLL
{
    public class Configuracao
    {
        LayoutPlanilha configuracao = new LayoutPlanilha();

        public string GetCaminhoArquivo() { return configuracao.CaminhoArquivoConfiguracao(); }

        public JObject CarregarCampos()
        {            
            return configuracao.GetFields();            
        }
        
        private List<string> JsonToList(JObject obj)
        {
            return JsonConvert.DeserializeObject<List<string>>(obj.ToString());
        }

        public bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) ||
                (strInput.StartsWith("[") && strInput.EndsWith("]")))
            {
                try
                {
                    var obj = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {                    
                    Console.WriteLine(jex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);                                        
                }
            }
            else
            {
                return false;
            }
        }
    }
}
