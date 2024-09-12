using System.Runtime.InteropServices.JavaScript;

namespace NumerosRomanos.Dominio
{
    public static class ConversorNumeraisRomanos
    {
        public static string Converter(int numeroIndoArabico)
        {
            int[] numerosBasico = {
                1, 5, 10, 50, 100, 500, 1000
            };

            if (numerosBasico.Contains(numeroIndoArabico))
            {
                switch (numeroIndoArabico)
                {
                    case 1:
                        return "I";

                    case 5:
                        return "V";

                    case 10:
                        return "X";

                    case 50:
                        return "L";

                    case 100:
                        return "C";

                    case 500:
                        return "D";

                    case 1000:
                        return "M";
                }
            }
            else if(numeroIndoArabico <= 3 && numeroIndoArabico > 0)
            {
                string romanoMenor = "I";
                string romano = "";

                int i = 0;

                while (i < numeroIndoArabico)
                {
                    romano += romanoMenor;

                    i++;
                }
                return romano;
            }

            return "\0";
        }
    }
}
