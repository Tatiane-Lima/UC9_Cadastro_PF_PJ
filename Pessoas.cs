using System;

namespace encontroRemoto2Uc9
{
    public abstract class Pessoas
    {
        public string? nome { get; set; }
        public Endereco? endereco { get; set; }
        public float rendimentos { get;set; }
        public abstract double PagarImposto(float salario);
    }
}