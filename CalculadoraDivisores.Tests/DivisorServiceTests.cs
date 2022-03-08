using NUnit.Framework;
using CalculadoraDivisores.Domain.Services;
using AutoFixture;

namespace CalculadoraDivisores.Tests
{
    [TestFixture]
    public class DivisorServiceTests
    {
        protected readonly Fixture Fixture = new Fixture();
        public DivisorService _divisorService;

        [SetUp]
        public void Setup()
        {
            _divisorService = Fixture.Create<DivisorService>();
        }

        [TestCase("100", true)]
        [TestCase("0100", true)]
        [TestCase("0", false)]
        [TestCase("-0", false)]
        [TestCase("-1", false)]
        [TestCase("100000000000", true)]
        public void ValidarEntrada(string input, bool resultadoEsperado)
        {
            var resultado = _divisorService.ValidarInput(input);

            Assert.That(resultado, Is.EqualTo(resultadoEsperado));
        }

        [TestCase("45", "1, 3, 5, 9, 15, 45", "1, 3, 5")]
        [TestCase("102", "1, 2, 3, 6, 17, 34, 51, 102", "1, 2, 3, 17")]
        public void DadoValorEntrada_CalcularDivisoresEDivisoresPrimos(string input, string resultadoDivisores, string resultadoDivisoresPrimos)
        {
            var valorEntrada = _divisorService.ConverterParaNumero(input);
            var resultado = _divisorService.CalcularDivisores(valorEntrada);
            Assert.That(resultado.listaDivisores, Is.EqualTo(resultadoDivisores));
            Assert.That(resultado.listaDivisoresPrimos, Is.EqualTo(resultadoDivisoresPrimos));
        }
    }
}