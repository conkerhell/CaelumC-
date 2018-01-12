﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    class ContaCorrente : Conta, ITributavel
    {

        public override void Saca(double valor)
        {
            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo += valor - 0.10;

        }

        public override void Deposita(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                Saldo += valor - 0.5;
            }
        }


        public double CalculaTributos()
        {
            return Saldo * 0.5;
        }
    }
}
