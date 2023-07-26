using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inss2206
{
    public class Operacoes
    {
        float inss, aliq, ir, valores;
        private object lb_SalarioFinal;


        public float INSS (float val)
        {
            if (val <= 1302.00)
            {
                inss = (float)(val * 0.075);

            }
            else if (val >= 1302.01 && val <= 2571.29)
            {
                inss = (float)(val * 0.09);
            }
            else if (val >= 2571.30 && val <= 3856.94)
            {
                inss = (float)(val * 0.12);
            }
            else if (val >= 3856.95 && val <= 7507.29)
            {
                inss = (float)(val * 0.14);
            }
            return inss;
        }
        public float ImpostoRenda (float num)
        {
            
            if (num >= 1903.99 && num <= 2826.65)
            {
                aliq = (float)0.075;
                ir = num * aliq;

                // valores = num - ir - inss;
               
            }
            else if (num >= 2826.66 && num <= 3751.05)
            {
                aliq = (float)0.15;
                ir = num * aliq;

               // valores = num - ir - inss;
                
            }
            else if (num >= 3751.06 && num <= 4664.68)
            {
                aliq = (float)0.225;
                ir = num * aliq;

                //valores = num - ir - inss;
                
            }
            else if (num >= 4664.68)
            {
                aliq = (float)0.275;
                ir = num * aliq;

               //valores = num - ir - inss;
               
            }
            return ir;

        }
       
    }
}
