using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CalculadoraDivisores.Domain.Services
{
    public class DivisorService : IDivisorService
    {
        private const string MSG_NUMERO_INVALIDO = "Valor inválido, digite um valor entre 1 e 100,000,000,000,000";

        public ResultadoDivisor CalcularDivisores(long input)
        {
            var divisores = EncontrarDivisores(input).ToList();
            var divisoresPrimos = FiltrarNumerosPrimos(divisores);
            var listaDivisores = FormatarListaNumerica(divisores);
            var listaDivisoresPrimos = FormatarListaNumerica(divisoresPrimos);
            if (divisores != null && divisores.Count > 1)
                listaDivisoresPrimos = "1, " + listaDivisoresPrimos;
            if (divisores != null && divisores.Count == 1)
                listaDivisoresPrimos = "1";
            return new ResultadoDivisor(listaDivisores, listaDivisoresPrimos);
        }

        public IEnumerable<long> EncontrarDivisores(long input)
        {
            for (long i = 1; i * i <= input; i++)
            {
                if (input % i == 0)
                {
                    yield return i;
                    if (i != input / i)
                        yield return input / i;
                }
            }
        }

        public List<long> FiltrarNumerosPrimos(List<long> divisores)
        {
            var listaNumerosPrimos = new List<long>();
            foreach (long numero in divisores)
            {
                if (ValidarNumeroPrimo(numero))
                    listaNumerosPrimos.Add(numero);
            }
            return listaNumerosPrimos;
        }

        public bool ValidarNumeroPrimo(long number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);
            long root = (long)Math.Sqrt(number);
            for (long i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public string FormatarListaNumerica(List<long> divisores)
        {
            divisores = divisores.OrderBy(x => x).ToList();
            return string.Join(", ", divisores.Select(n => n.ToString()).ToArray());
        }

        public bool ValidarInput(string input)
        {
            if (!Regex.IsMatch(input, @"^\d*[1-9]\d*$"))
            {
                return false;
            }
            return true;
        }

        public long ConverterParaNumero(string input)
        {
            long numeroEntrada;
            try
            {
                numeroEntrada = Convert.ToInt64(input);
                if (numeroEntrada > 100000000000000)
                {
                    throw new Exception(MSG_NUMERO_INVALIDO);
                }
                return numeroEntrada;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("Value was either too large or too small for an Int64."))
                {
                    throw new Exception(MSG_NUMERO_INVALIDO);
                }
                else
                    throw;
            }
        }


    }
}
