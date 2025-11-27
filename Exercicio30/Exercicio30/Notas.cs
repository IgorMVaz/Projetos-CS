namespace Exercicio30
{
    class Notas
    {
        public string NomeAluno;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularMedia()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string VerificarAprovacao()
        {
            double media = CalcularMedia();
            if (media >= 60.0)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }

        public double FaltamteParaAprovacao()
        {
            double media = CalcularMedia();
            if (media >= 60.0)
            {
                return 0.0;
            }
            else
            {
                return 60.0 - media;
            }
        }
    }
}
