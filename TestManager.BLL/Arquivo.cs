using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using TestManager.Model.Configuracao;

namespace TestManager.BLL
{
    public class Arquivo
    {
        Excel.Range range = null;

        public async Task<string> GerarWorkbook(string caminhoSalvar, string nomeArquivo)
        {
            try
            {
                bool retorno = await Task.Run(() =>
                {
                    Excel.Application application =
                    new Excel.Application();

                    Excel.Workbook workbook =
                        application.Workbooks.Add();
                    try
                    {
                        this.CriaPlanilha(workbook);

                        workbook.SaveAs(Path.Combine(caminhoSalvar, nomeArquivo), Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value,
                            Missing.Value, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
                            Excel.XlSaveConflictResolution.xlUserResolution, true,
                            Missing.Value, Missing.Value, Missing.Value);

                        GC.Collect();
                        GC.WaitForPendingFinalizers();

                        Marshal.ReleaseComObject(range);

                        workbook.Close();
                        Marshal.ReleaseComObject(workbook);

                        application.Quit();
                        Marshal.ReleaseComObject(application);

                        return true;
                    }
                    catch (Exception ex)
                    {
                        GC.Collect();
                        GC.WaitForPendingFinalizers();

                        workbook.Close();
                        Marshal.ReleaseComObject(workbook);

                        application.Quit();
                        Marshal.ReleaseComObject(application);

                        throw new Exception(ex.Message);
                    }
                });

                return Path.Combine(caminhoSalvar, nomeArquivo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private Excel.Sheets CriaPlanilha(Excel.Workbook workbook)
        {
            try
            {
                LayoutPlanilha modelo = new LayoutPlanilha();
                var planilhas = modelo.GetFields();

                foreach (var planilha in planilhas)
                {
                    Excel.Worksheet sheet = workbook.Worksheets.Add();
                    sheet.Name = planilha.Key;
                    int col = 1;

                    foreach (var item in planilha.Value)
                    {
                        range = sheet.Cells[1, col];
                        range.Value = item.ToString();
                        col++;
                    }
                }

                return workbook.Worksheets;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
