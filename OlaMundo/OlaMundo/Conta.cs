using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Ao criar uma proporty por de baixo dos panos o sistema cria um atributo privado
 
 */
namespace OlaMundo
{
    class Conta
    {
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public int Numero {get; set;}
        public byte Idade { get; set; }
        
        public void Deposita(Double valor)
        {
            this.Saldo += valor;
        }

        public bool Saca(Double valor)
        {
            if (Idade < 18 && valor > 200)
            {
                return false;
            }

            if (Saldo < valor)
            {
                return false;
            }

            Saldo -= valor;
            return true;
        }

        public void Transfere(Double valor, Conta contaDestino)
        {
            this.Saca(valor);
            this.Deposita(valor);
        }

       
    }
}
