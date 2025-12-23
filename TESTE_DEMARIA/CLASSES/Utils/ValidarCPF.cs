using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_DEMARIA.CLASSES.Utils
{
    internal class ValidarCPF
    {

        public class CPFValidator
        {
            public static (bool IsValid, string Message) Validar(string cpf)
            {
                cpf = new string(cpf.Where(char.IsDigit).ToArray());

                if (string.IsNullOrEmpty(cpf))
                    return (false, "CPF não pode estar vazio.");

                if (cpf.Length != 11)
                    return (false, "CPF deve conter exatamente 11 dígitos.");

                if (cpf.All(c => c == cpf[0]))
                    return (false, "CPF inválido: todos os dígitos iguais.");

                int CalcularDigito(int length)
                {
                    int soma = 0;
                    for (int i = 0; i < length; i++)
                        soma += (cpf[i] - '0') * (length + 1 - i);

                    int resto = soma % 11;
                    return resto < 2 ? 0 : 11 - resto;
                }

                int digito1 = CalcularDigito(9);
                int digito2 = CalcularDigito(10);

                if (digito1 != (cpf[9] - '0'))
                    return (false, "CPF inválido: primeiro dígito verificador incorreto.");

                if (digito2 != (cpf[10] - '0'))
                    return (false, "CPF inválido: segundo dígito verificador incorreto.");

                return (true, "CPF válido.");
            }
        }

    }
}
