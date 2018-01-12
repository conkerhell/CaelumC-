using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco
{
    public partial class Form1 : Form
    {
        private List<Conta> contas;
        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente joao = new Cliente("joao");

            this.contas = new List<Conta>();

            Conta contaJoao = new ContaPoupanca();

            contaJoao.Numero = 345;
            contaJoao.Titular = joao;
            AdicionaConta(contaJoao);

            Cliente maria = new Cliente("Maria");
            Conta contaMaria = new ContaCorrente();
            contaMaria.Numero = 1234;
            contaMaria.Titular = maria;
            AdicionaConta(contaMaria);

            Cliente jose = new Cliente("Jose");
            Conta contaJose = new ContaCorrente();
            contaJose.Numero = 594;
            contaJose.Titular = jose;
            AdicionaConta(contaJose);

            /*foreach (Conta c in contas)
            {
               comboContas.Items.Add("Titular: " + c.Titular.Nome);
            }


           

               Conta conta = new ContaPoupanca();
               c1.Deposita(100.00);
               c1.Saca(50.00);
               MessageBox.Show("Conta poupança " + c1.Saldo);


               Conta c2 = new Conta();
               c2.Deposita(100.00);
               c2.Saca(50.00);
               MessageBox.Show("Conta poupança " + c2.Saldo);*/

        }


        public void AdicionaConta(Conta conta)
        {
            //this.contasa conta;

            //this.numeroDeContas++;
            this.contas.Add(conta);
            comboContas.Items.Add(conta);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoDeposito_click(object sender, EventArgs e)
        {

            Conta selecionada = (Conta)comboContas.SelectedItem;
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            //int indice = comboContas.SelectedIndex;
           // Conta contaSelecionada = contas[indice];
            try
            {
                selecionada.Deposita(valor);
                textoSaldo.Text = selecionada.Saldo.ToString();
                MessageBox.Show("Deposito efetuado!");
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("Argumento Inválido");
            }



        }

        private void botaoSaca_click(object sender, EventArgs e)
        {
            Conta selecionada = (Conta)comboContas.SelectedItem;
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            /*int indice = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indice];*/

            try
            {
                selecionada.Saca(valor);
                textoSaldo.Text = selecionada.Saldo.ToString();
                MessageBox.Show("Saque Efetuado");
            }

            catch(SaldoInsuficienteException ex)
            {
                MessageBox.Show("Saldo Não Suficiente");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indice];
            textoTitular.Text = contaSelecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = contaSelecionada.Saldo.ToString();
        }

        private void botaoNovaConta(object sender, EventArgs e)
        {
            FormCadastroContas formCadastro = new FormCadastroContas(this);
            formCadastro.Show();
        }

        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);
            MessageBox.Show("Imposto da conta corrente = " + conta.CalculaTributos());
            ITributavel t = conta;

            MessageBox.Show("Impostos da conta pela interface = " + t.CalculaTributos());

            SeguraDeVida sv = new SeguraDeVida();
            MessageBox.Show("Impostos do Seguro = " + sv.CalculaTributos());

            t = sv;
            MessageBox.Show("Imposto do Seguro pela Interface = " + t.CalculaTributos());
        }

        
    }
}
