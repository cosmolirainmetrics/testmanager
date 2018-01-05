using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;

namespace TestManager.Model.Configuracao
{
    public class LayoutPlanilha
    {
        private string _caminhoDatabase =
            AppContext.BaseDirectory.ToString() + @"Configuracao\LayoutPlanilha.json";

        public JObject model;

        public LayoutPlanilha()
        {
            this.GetSchema();
        }

        private void GetSchema()
        {
            using (var str = File.OpenText(this._caminhoDatabase))
            {
                this.model = JObject.Parse(                    
                    str.ReadToEnd());
                str.Close();
            }                
        }

        public JObject GetFields()
        {
            return this.model;
        }

        public string CaminhoArquivoConfiguracao()
        {
            return this._caminhoDatabase;
        }
    }
}
