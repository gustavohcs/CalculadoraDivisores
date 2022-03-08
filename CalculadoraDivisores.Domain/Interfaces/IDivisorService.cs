namespace CalculadoraDivisores.Domain.Services
{
    public interface IDivisorService
    {
        ResultadoDivisor CalcularDivisores(long numeroEntrada);

        bool ValidarInput(string numeroEntrada);

        long ConverterParaNumero(string numeroEntrada);
    }
}
