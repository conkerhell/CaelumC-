using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Banco.Busca;


namespace Banco
{
    public partial class FormCadastroContas : Form
    {
        private Form1 form1;
        private ICollection<String> devedores;

        public FormCadastroContas(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.Geralist();
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            String titular = textoTitular.Text;
            bool ehDevedor = false;
            for (int i = 0; i < 30000; i++)
            {
                ehDevedor = this.devedores.Contains(titular);
            }
            if (!ehDevedor)
            {
                Cliente novoCliente = new Cliente(textoTitular.Text);
                Conta novaConta = new ContaPoupanca();
                novaConta.Numero = Convert.ToInt16(textoNumero.Text);
                novaConta.Titular = novoCliente;

                form1.AdicionaConta(novaConta);
                MessageBox.Show("Conta Adicionada");
                Dispose();
            }
            else
            {
                MessageBox.Show("Devedor");
            }
            
        }

        private void FormCadastroContas_Load(object sender, EventArgs e)
        {

        }
    }
}
