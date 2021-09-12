using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PresentacionForm
{
    public partial class FormPresentacion : Form
    {
        public FormPresentacion()
        {
            InitializeComponent();
        }

        private void btn_DividirPorCero_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            try
            {
                resultado = Logic.Dividir((int)this.nud_Dividendo.Value);
                MessageBox.Show($"El resultado es: {resultado}");
            }
            catch (CustomException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                MessageBox.Show($"Se termino de realizar la operacion");
            }
        }

        private void btn_DividirPorDivisor_Click(object sender, EventArgs e)
        {
            float resultado = 0;
            try
            {
                resultado = Logic.Dividir((int)this.nud_Dividendo.Value, (int)this.nud_Divisor.Value);
                MessageBox.Show($"El resultado es: {resultado}");
            }catch(CustomException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
    
        }
    }
}
