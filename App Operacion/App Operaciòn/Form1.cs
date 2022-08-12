using Lib_Operacion;
using System;
using System.Windows.Forms;

namespace App_Operacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            int num1, num2;
            try
            {
                // Capturamos los valores de las cajas de texto.
                num1 = Convert.ToInt32(txtn1.Text);
                num2 = Convert.ToInt32(txtn2.Text);

                // Instanciar la logica de negocios
                Operacion objOp = new Operacion();

                // Enviar los valores a la LN
                objOp.SetN1 = num1;
                objOp.SetN2 = num2;

                if (objOp.Calcular())
                {
                    txtsuma.Text = objOp.GetSuma.ToString();
                }
                else
                {
                    MessageBox.Show(objOp.GetError);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
