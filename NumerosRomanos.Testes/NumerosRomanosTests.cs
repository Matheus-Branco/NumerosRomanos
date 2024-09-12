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

            string numeralRomano = ConversorNumeraisRomanos.Converter(numeroIndoArabico);

            Assert.AreEqual("I", numeralRomano);
        }

        [TestMethod]
        public void Deve_Converter_2_Para_II()
        {
            var numeroIndoArabico = 2;

            string numeralRomano = ConversorNumeraisRomanos.Converter(numeroIndoArabico);

            Assert.AreEqual("II", numeralRomano);
        }

        [TestMethod]
        public void Deve_Converter_3_Para_III()
        {
            var numeroIndoArabico = 3;

            string numeralRomano = ConversorNumeraisRomanos.Converter(numeroIndoArabico);

            Assert.AreEqual("III", numeralRomano);
        }

        [TestMethod]
        public void Deve_Converter_5_Para_V()
        {
            var numeroIndoArabico = 5;

            string numeralRomano = ConversorNumeraisRomanos.Converter(numeroIndoArabico);

            Assert.AreEqual("V", numeralRomano);
        }

        [TestMethod]
        public void Deve_Converter_10_Para_X()
        {
            var numeroIndoArabico = 10;

            string numeralRomano = ConversorNumeraisRomanos.Converter(numeroIndoArabico);

            Assert.AreEqual("X", numeralRomano);
        }

        [TestMethod]
        public void Deve_Converter_50_Para_L()
        {
            var numeroIndoArabico = 50;

            string numeralRomano = ConversorNumeraisRomanos.Converter(numeroIndoArabico);

            Assert.AreEqual("L", numeralRomano);
        }

        [TestMethod]
        public void Deve_Converter_100_Para_C()
        {
            var numeroIndoArabico = 100;

            string numeralRomano = ConversorNumeraisRomanos.Converter(numeroIndoArabico);

            Assert.AreEqual("C", numeralRomano);
        }

        [TestMethod]
        public void Deve_Converter_500_Para_D()
        {
            var numeroIndoArabico = 500;

            string numeralRomano = ConversorNumeraisRomanos.Converter(numeroIndoArabico);

            Assert.AreEqual("D", numeralRomano);
        }

        [TestMethod]
        public void Deve_Converter_1000_Para_M()
        {
            var numeroIndoArabico = 1000;

            string numeralRomano = ConversorNumeraisRomanos.Converter(numeroIndoArabico);

            Assert.AreEqual("M", numeralRomano);
        }
    }
}