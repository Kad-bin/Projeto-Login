using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projeto_Login
{
    class ValidarNome
    {
        public static bool ValidarNomes(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            // Padrão regex para nomes
            string pattern = @"[A-Z][a-z].* [A-Z][a-z].*";

            return Regex.IsMatch(
                name,
                pattern,
                RegexOptions.IgnoreCase,
                TimeSpan.FromMilliseconds(200) // Timeout para evitar ReDoS
            );
        }
    }
}
