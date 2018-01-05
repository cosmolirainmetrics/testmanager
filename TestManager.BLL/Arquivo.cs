using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;
using TestManager.Model;
using TestManager.Model.Configuracao;
using TestManager.Common.Tratamento;

namespace TestManager.BLL
{
    public class Arquivo : IDisposable
    {
        //private Excel.Application xls = new Excel.Application();
        //private Excel.Workbook xWork = null;
        //private Excel.Range xRange = null;
        
        private List<string> palavrasReservadas =
            new List<string>(
                new string[] {
                    "Funcionalidade",
                    "Cenario",
                    "Esquema do Cenario"
                });

        ~Arquivo()
        {
           
        }

        public async Task<List<Funcionalidade>> ImportarPlanilha(string caminho)
        {            
            //xWork = xls.Workbooks.Open(caminho);
            return await this.ExtraiPlanilha("Funcionalidade", caminho);

            //Excel.Worksheet sheet = xWork.Sheets["Funcionalidade"];            
            //xRange = sheet.UsedRange;

            //int rowCount = xRange.Rows.Count;
            //int colCount = xRange.Columns.Count;

            //for(int row = 2; row <= rowCount; row++)
            //{
            //    Funcionalidade func = new Funcionalidade();

            //    if (xRange[row, 1].Value != null)
            //    {

            //        func.ID = Texto.RetiraAcento(xRange[row, 1].Value);
            //        func.Descricao = Texto.RetiraAcento(xRange[row, 2].Value);
            //        func.Eu = Texto.RetiraAcento(xRange[row, 3].Value);
            //        func.Para = Texto.RetiraAcento(xRange[row, 4].Value);
            //        func.Quero = Texto.RetiraAcento(xRange[row, 5].Value);

            //        funcionalidades.Add(func);
            //    }
            //}



            //return "";
            ////await Task.Run(() =>
            ////{



            ////    //foreach (Excel._Worksheet sheet in xWork.Sheets)
            ////    //{

            ////    //}
            ////});
        }

        private async Task<List<Funcionalidade>> ExtraiPlanilha( string nomePlanilha, string caminho)
        {            
            List<Funcionalidade> funcionalidades = new List<Funcionalidade>();

            var task = Task.Run(() =>
            {
                Excel.Application xls = new Excel.Application();
                Excel.Workbook xWork = null;
                Excel.Range xRange = null;

                
                xWork = xls.Workbooks.Open(caminho);
                Excel.Worksheet sheet = xWork.Sheets["Funcionalidade"];                
                xRange = sheet.UsedRange;

                // Aqui é o ponto
                var t = xRange.Find("que possa gerar uma operação", Missing.Value, 
                    Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart,    
                    Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, false,
                    Missing.Value, Missing.Value);

                int rowCount = xRange.Rows.Count;
                int colCount = xRange.Columns.Count;

                for (int row = 2; row <= rowCount; row++)
                {
                    Funcionalidade func = new Funcionalidade();

                    if (xRange[row, 1].Value != null)
                    {
                        func.ID = Texto.RetiraAcento(xRange[row, 1].Value);
                        func.Descricao = Texto.RetiraAcento(xRange[row, 2].Value);
                        func.Eu = Texto.RetiraAcento(xRange[row, 3].Value);
                        func.Para = Texto.RetiraAcento(xRange[row, 4].Value);
                        func.Quero = Texto.RetiraAcento(xRange[row, 5].Value);

                        funcionalidades.Add(func);
                    }
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(xRange);

                xWork.Close();
                Marshal.ReleaseComObject(xWork);

                xls.Quit();
                Marshal.ReleaseComObject(xls);                
            });
                        
            task.Wait();
            task.Dispose();

            return funcionalidades;
        }

        //public async Task<bool> ImportarLayoutAlpha(string caminhoPlanilha, string caminhoArquivoSaida)
        //{
        //    xWork = xls.Workbooks.Open(caminhoPlanilha);
        //    StringBuilder stringBuilder = new StringBuilder();
        //    int planilhas = 1;
        //    Excel.Range valor;

        //    await Task.Run(() =>
        //    {
        //        using (var str = new StreamWriter(File.Create(caminhoArquivoSaida)))
        //        {
        //            foreach (Excel._Worksheet xSheet in xWork.Sheets)
        //            {
        //                xRange = xSheet.UsedRange;
        //                int rowCount = xRange.Rows.Count;
        //                int colCount = xRange.Columns.Count;

        //                if (planilhas == 1)
        //                {
        //                    for (int col = 1; col <= colCount; col++)
        //                    {
        //                        if (col == 1)
        //                            str.WriteLine();

        //                        valor = xRange.Cells[1, col];

        //                        if (valor != null && valor.Value2 != null)
        //                        {
        //                            if (palavrasReservadas.Contains(Texto.RetiraAcento(valor.Value2)))
        //                                str.Write(Texto.RetiraAcento(string.Format("{0}: ", valor.Value2.ToString())));
        //                            else
        //                                str.Write(Texto.RetiraAcento(string.Format("{0} ", valor.Value2.ToString())));

        //                            valor = xRange.Cells[2, col];

        //                            if (valor != null && valor.Value2 != null)
        //                            {
        //                                if (palavrasReservadas.Contains(valor.Value2))

        //                                    str.WriteLine(Texto.RetiraAcento(string.Format("{0}: ", valor.Value2.ToString())));
        //                                else
        //                                    str.WriteLine(Texto.RetiraAcento(string.Format("{0} ", valor.Value2.ToString())));
        //                            }
        //                        }
        //                    }

        //                    str.WriteLine();
        //                }
        //                else
        //                {
        //                    int linha = 1;
        //                    int coluna = 1;

        //                    valor = xRange.Cells[linha, coluna];

        //                    if (valor != null && valor.Value2 != null)
        //                    {
        //                        if (palavrasReservadas.Contains(Texto.RetiraAcento(valor.Value2)))
        //                            str.Write(Texto.RetiraAcento(string.Format("{0}: ", valor.Value2.ToString())));
        //                        else
        //                            str.Write(Texto.RetiraAcento(string.Format("{0} ", valor.Value2.ToString())));

        //                    }

        //                    valor = xRange.Cells[linha + 1, coluna];
        //                    str.WriteLine(Texto.RetiraAcento(string.Format("{0} ", valor.Value2.ToString())));
        //                    coluna++;

        //                    while (linha <= rowCount)
        //                    {
        //                        for (int col = coluna; coluna <= colCount; coluna++)
        //                        {
        //                            valor = xRange.Cells[1, coluna];

        //                            if (palavrasReservadas.Contains(Texto.RetiraAcento(valor.Value2)))
        //                                str.Write(Texto.RetiraAcento(string.Format("{0}: ", valor.Value2.ToString())));
        //                            else
        //                                str.Write(Texto.RetiraAcento(string.Format("{0} ", valor.Value2.ToString())));

        //                            valor = xRange.Cells[linha + 1, coluna];

        //                            if (valor != null && valor.Value2 != null)
        //                            {
        //                                str.WriteLine(Texto.RetiraAcento(string.Format("{0} ", valor.Value2.ToString())));
        //                            }
        //                        }

        //                        str.WriteLine();
        //                        coluna = 1;
        //                        linha++;
        //                    }
        //                }

        //                planilhas++;
        //            }
        //        }
        //    });

        //    return true;
        //}




        //public async Task<string> GerarWorkbook(string caminhoSalvar, string nomeArquivo)
        //{
        //    try
        //    {
        //        bool retorno = await Task.Run(() =>
        //        {
        //            Excel.Application application =
        //            new Excel.Application();

        //            Excel.Workbook workbook =
        //                application.Workbooks.Add();
        //            try
        //            {
        //                this.CriaPlanilha(workbook);

        //                workbook.SaveAs(Path.Combine(caminhoSalvar, nomeArquivo), Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value,
        //                    Missing.Value, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
        //                    Excel.XlSaveConflictResolution.xlUserResolution, true,
        //                    Missing.Value, Missing.Value, Missing.Value);
                       
        //                return true;
        //            }
        //            catch (Exception ex)
        //            {
                        

        //                throw new Exception(ex.Message);
        //            }
        //        });

        //        return Path.Combine(caminhoSalvar, nomeArquivo);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //private Excel.Sheets CriaPlanilha(Excel.Workbook workbook)
        //{
        //    try
        //    {
        //        LayoutPlanilha modelo = new LayoutPlanilha();
        //        var planilhas = modelo.GetFields();

        //        foreach (var planilha in planilhas)
        //        {
        //            Excel.Worksheet sheet = workbook.Worksheets.Add();
        //            sheet.Name = planilha.Key;
        //            int col = 1;

        //            foreach (var item in planilha.Value)
        //            {
        //                xRange = sheet.Cells[1, col];
        //                xRange.Value = item.ToString();
        //                col++;
        //            }
        //        }

        //        return workbook.Worksheets;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        public void Dispose()
        {
            
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            //Marshal.ReleaseComObject(xRange);

            //xWork.Close();
            //Marshal.ReleaseComObject(xWork);

            //xls.Quit();
            //Marshal.ReleaseComObject(xls);
        }
    }
}
