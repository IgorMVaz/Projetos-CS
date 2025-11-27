namespace Exercicio31
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double ConverterDolarParaReal(double valorEmDolar, double cotacaoDolar)
        {
            double total = valorEmDolar * cotacaoDolar;
            return total + (total * Iof / 100.0);
        }
    }
}
