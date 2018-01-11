using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo
{
    class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereco;
        public int idade;

        public bool EhMaiorDeIdade()
        {
            if(idade >= 18)
            {
                return true;
            }

            return false;
        }
// Construtor opcional
        public Cliente()
        {
           
        }
//Construtor obrigatório .
        public Cliente (string nome)
        {
            this.nome = nome;
        }
           

    }
}
