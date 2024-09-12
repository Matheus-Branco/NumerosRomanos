namespace NumerosRomanos.Dominio
{
    public static class ConversorNumeraisRomanos
    {
        public static string Converter(int numeroIndoArabico)
        {
            if (numeroIndoArabico == 1 ||
                numeroIndoArabico == 5 ||
                numeroIndoArabico == 10 ||
                numeroIndoArabico == 50 ||
                numeroIndoArabico == 100 ||
                numeroIndoArabico == 500 ||
                numeroIndoArabico == 1000)
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
            else
            {
                Calcular(numeroIndoArabico);
            }

            return "\0";
        }

        public static string Calcular(int numeroIndoArabico)
        {
            

            return "\0";
        }
    }
}
