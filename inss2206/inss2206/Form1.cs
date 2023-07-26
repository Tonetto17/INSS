using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inss2206
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float resultado, numero, imposto;

       

        Operacoes op = new Operacoes();
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if(tbox_SalarioInicial.Text== string.Empty)
            {
                MessageBox.Show("Preencha o campo", "ATENÇÃO");
            }
            else
            {
                numero= float.Parse(tbox_SalarioInicial.Text);
                resultado = op.INSS(numero);
                lb_Inss.Text = resultado.ToString("C");


                imposto = op.ImpostoRenda(numero);

                float total = numero - imposto - resultado;

                lb_ImpostoRenda.Text= imposto.ToString("C");
                
               // valor = op.ImpostoRenda(numero);
                lb_SalarioFinal.Text = total.ToString("C");

            }

        }
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tbox_SalarioInicial.Clear();
            lb_Inss.Text = "";
            lb_ImpostoRenda.Text = "";
            lb_SalarioFinal.Text = "";       
        }
    }
}
