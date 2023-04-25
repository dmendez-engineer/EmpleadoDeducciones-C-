using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EmpleadoDeducciones
{
    
    public partial class Form1 : Form
    {
        Empleado e1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            String cedula = mskCedula.Text;
            String nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            double salarioBruto = Double.Parse(mskSalarioBruto.Text);




            if (salarioBruto <= 100000)
            {
                errorProvider1.SetError(mskSalarioBruto, "El salario tiene que ser mayor a 100.000");
                return;
            }

            decimal edad = nudEdad.Value;
            char genero;
            if (rdbFemenino.Checked)
            {
                genero = 'F';
            }
            else
            {
                if (rdbMasculino.Checked)
                {
                    genero = 'M';
                }
                else
                {
                    errorProvider1.SetError(mskSalarioBruto, "Tiene que seleccionar el genero");
                    return;
                }
            }

            e1 = new Empleado(cedula, nombre, fecha, salarioBruto, genero, edad);

            e1.agregarDeduccion(new Deduccion("Seguro Social", 0.09));
            e1.agregarDeduccion(new Deduccion("Ahorro Obligatorio", 0.09));

            if (chkPolizaVida.Checked)
            {
                e1.agregarDeduccion(new Deduccion("Poliza de vida", 0.02));
            }
            else
            {
                if (chkAsociacion.Checked)
                {
                    e1.agregarDeduccion(new Deduccion("Asociacion", 0.03));
                }
            }
           
            txtSalarioNeto.Text = (e1.aplicarDeducciones()).ToString();
           


        }
    }
}
