using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestManager.BLL;


namespace TestManagerConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuracao conf = new Configuracao();

            //Console.WriteLine(conf.GerarWorkbook(@"c:\projetos", "saida.xlsx").Result);
            conf.CarregarCampos();
            Console.ReadLine();
        }
    }
}
