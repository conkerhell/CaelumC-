using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ola Mundo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idade1 = 29;
            int idade2 = 73;
            int idade3 = 58;
            int soma = idade1 + idade2 + idade3;
            float media = soma / 3.0f;

            MessageBox.Show("A média de idade das 3 pessoas são: " + media);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);
            MessageBox.Show("Valor de a1 é: " + a1);
            MessageBox.Show("Valor de a2 é: " + a2);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
                MessageBox.Show("Total " + total);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int total = 0;
            int n = 1;
            while (n <= 1000)
            {
                total = n + total;

                n++;
            }

            MessageBox.Show(" Soma de 1 a 1000 é: " + total);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n = 1;
            int x;

            for (; n <= 100; n++)
            {
                x = n % 3;

                if (x == 0)
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Imprimindo numero " + n);

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n = 1;
            int x;
            int soma = 0;

            for (; n <= 100; n++)
            {
                x = n % 3;
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    soma += n;
                }

            }
            MessageBox.Show("O resultado final " + soma);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n = 1;
            int x;

            /*  for (; n <= 30; n++)
              {

                  x = n % 4;

                  if (x != 0)
                  {
                      continue;
                  }

                  else
                  {
                      MessageBox.Show(" Numero divisível por 4 são: " + n);

                  }
              }*/

            // n == 31

            while (n <= 30)
            {
                x = n % 4;

                n++;

                if (n % 3 == 0 || n % 4 == 0)
                {
                    MessageBox.Show(" Numero divisível por 4 são: " + n);
                }
                else
                {
                    continue;

                }

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int i = 1; i <= 5; i++)
            {
                fatorial = fatorial * i;

                MessageBox.Show("O valor fatorial é " + fatorial);
            }

        }
    }
}

