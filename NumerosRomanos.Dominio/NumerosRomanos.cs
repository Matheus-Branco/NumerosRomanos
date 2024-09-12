namespace NumerosRomanos.Dominio
{
    public static class ConversorNumerosaisRomanos
    {
        public static string Converter(int numeroIndoArabico)
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

            return "\0";
        }
    }
}
