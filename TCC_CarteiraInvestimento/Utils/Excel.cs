using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ClosedXML.Excel;

namespace TCC_CarteiraInvestimento.Utils
{
    public static class Excel
    {
        private static XLWorkbook _workbook;
        private static IXLWorksheet _worksheet;
        private static string _arquivo;

        #region ZScore

        public static void InicializarArquivo()
            => _workbook = new XLWorkbook();

        public static void ExportarZScore(string nomeEtiqueta, List<(string codEmpresa, decimal valor, decimal score)> dados)
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

        #endregion

        public static void InicializarArquivo([NotNull] string nomeArquivo)
        {
            _workbook = new XLWorkbook();
            _arquivo = nomeArquivo;
        }

        public static void IdentificarEtiqueta([NotNull] string nomeEtiqueta)
            => _worksheet = _workbook.Worksheets.Add(nomeEtiqueta);

        public static void GravarCelula([NotNull] string celula, [NotNull] object valor, string comentario = null)
        {
            if (!string.IsNullOrEmpty(comentario))
                _worksheet.Cell(celula).Comment.SetVisible().AddText(comentario);

            _worksheet.Cell(celula).Value = valor;
        }

        public static void MesclarCelulas(string celula1, string celula2)
        {
            _worksheet.Range($"{celula1}:{celula2}").Merge();
        }

        public static void SalvarAlteracoes()
            => _workbook.SaveAs(_arquivo);

        public static void LiberarRecursos()
        {
            _workbook.Dispose();
        }
    }
}

/*
    InicializarArquivo
    IdentificarEtiqueta
        Loop begin
        GravarCelula
        SalvarAlteracoes
        end Loop
    LiberarRecursos
 */
