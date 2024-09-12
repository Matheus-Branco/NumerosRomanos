using NumerosRomanos.Dominio;

namespace NumerosRomanos.Testes
{
    [TestClass]
    public class ConversorNumeraisRomanosTests
    {
        [TestMethod]
        public void Deve_Converter_1_Para_I()
        {
            var numeroIndoArabico = 1;

            string numeralRomano = ConversorNumerosaisRomanos.Converter(numeroIndoArabico);

            Assert.AreEqual("I", numeralRomano);
        }
    }
}