namespace CalculadoraDivisores.Domain
{
    public class ResultadoDivisor
    {
        public ResultadoDivisor(string divisores, string divisoresPrimos)
        {
            listaDivisores = divisores;
            listaDivisoresPrimos = divisoresPrimos;
        }

        public string listaDivisores { get; set; }
        public string listaDivisoresPrimos { get; set; }
    }
}
