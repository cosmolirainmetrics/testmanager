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
            this.model = JObject.Parse(
                File.OpenText(this._caminhoDatabase).ReadToEnd()
                );
        }

        public JObject GetFields()
        {
            return this.model;
        }
    }
}
