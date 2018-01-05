using System.Globalization;
using System.Text;

namespace TestManager.Common.Tratamento
{
    public static class Texto
    {
        public static string RetiraAcento(this string valor)
        {
            StringBuilder retorno = new StringBuilder();
            var arrayTexto = valor.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letra in arrayTexto)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letra) != UnicodeCategory.NonSpacingMark)
                    retorno.Append(letra);
            }
            return retorno.ToString();
        }
    }
}
