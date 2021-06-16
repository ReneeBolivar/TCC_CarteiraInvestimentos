using System.Collections.Generic;
using ClosedXML.Excel;

namespace TCC_CarteiraInvestimento.Utils
{
    public static class Excel
    {
        public readonly static XLWorkbook _workbook = new XLWorkbook();

        public static void Exportar(string nomeEtiqueta, List<(string codEmpresa, decimal valor, decimal score)> dados)
        {
            var worksheet = _workbook.Worksheets.Add(nomeEtiqueta);

            worksheet.GravarCabecalho();
            worksheet.GravarDados(dados);

            _workbook.SaveAs("C:\\Users\\Renee\\Desktop\\zscore.xlsx");
        }

        private static IXLWorksheet GravarCabecalho(this IXLWorksheet worksheet)
        {
            worksheet.Cell("A1").Value = "Empresa";
            worksheet.Cell("B1").Value = "Valor (R$)";
            worksheet.Cell("C1").Value = "ZScore";

            return worksheet;
        }

        private static IXLWorksheet GravarDados(this IXLWorksheet worksheet, List<(string codEmpresa, decimal valor, decimal score)> dados)
        {
            for (int i = 2; i < dados.Count; i++)
            {
                worksheet.Cell($"A{i}").Value = dados[i].codEmpresa;
                worksheet.Cell($"B{i}").Value = dados[i].valor;
                worksheet.Cell($"C{i}").Value = dados[i].score;
            }

            return worksheet;
        }
    }
}
