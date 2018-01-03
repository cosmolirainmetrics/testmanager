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
        public JObject CarregarCampos()
        {
            LayoutPlanilha configuracao = new LayoutPlanilha();
            return configuracao.GetFields();            
        }

        private List<string> JsonToList(JObject obj)
        {
            return JsonConvert.DeserializeObject<List<string>>(obj.ToString());
        }
    }
}
