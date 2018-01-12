using System;

namespace Banco.Contas
{
    public abstract class Conta
    {
        public Conta()
        {

        }

        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; set; }

        public abstract void Deposita(double valor);
        

        public abstract void Saca(double valor);

        public override string ToString()
        {
            return "Titular: " + this.Titular.Nome + "Numero   " + this.Numero;
        }
    }
}