using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Utils
{
    class Validacao
    {

        public static bool ValidarCpf(String cpf)
        {
            
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }

            switch (cpf)
            {
                case "00000000000":
                    return false;
                case "11111111111":
                    return false;
                case "22222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;                                  
            }
            #region var
            int peso = 10;
            int numCpf;
            int soma = 0;
            int digt1;
            int resto;
            int digt2;
            #endregion

            #region dig1
            for (int i = 0; i <9; i++)
            {
                numCpf = Convert.ToInt32(cpf[i].ToString());
                soma += numCpf * peso;
                peso--;
            }

            resto = soma % 11;
            
            if (resto < 2)
            {
                digt1 = 0;
            }
            else
            {
                digt1 = 11 - resto;
            }

            peso = 11;
            soma = 0;
            #endregion

            #region dig2
            for (int i = 0; i < 10; i++)
            {
                numCpf = Convert.ToInt32(cpf[i].ToString());
                soma += numCpf * peso;
                peso--;
            }

            resto = soma % 11;
            
            if (resto < 2)
            {
                digt2 = 0;
            }
            else
            {
                digt2 = 11 - resto;
            }

            #endregion

            if (digt1 ==Convert.ToInt32(cpf[9].ToString())  && digt2== Convert.ToInt32(cpf[10].ToString()))
            {
                return true;
            }

            return false;

        }
    }
}
