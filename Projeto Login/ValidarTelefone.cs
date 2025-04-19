using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projeto_Login
{
    class ValidarTelefone
    {
        public static bool ValidarTelefones(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            // Padrão regex para nomes
            string pattern = @"[0-9]{2}-([0-9]{8}|[0-9]{9})";

            return Regex.IsMatch(
                name,
                pattern,
                RegexOptions.IgnoreCase,
                TimeSpan.FromMilliseconds(200) // Timeout para evitar ReDoS
            );
        }
    }
}
