using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoDeducciones
{
   public class Empleado
    {
        public String cedula { set; get; }

        public FormPago formaPago { set; get; }
        public List<Deduccion> ListaDeducciones { get; set; }
        public String nombre { set; get; }
        public decimal edad { set; get; }
        public DateTime fechaNacimiento { set; get; }
        double salarioBruto { set; get; }
        char genero { set; get; }

        public Empleado(String cedula, String nombre, DateTime fecha, double salario, char gen,decimal edad)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            ListaDeducciones = new List<Deduccion>();
            this.fechaNacimiento = fecha;
            this.salarioBruto = salario;
            this.genero = gen;
            this.edad = edad;
        }

        public void agregarDeduccion(Deduccion oDeduccion)
        {
            this.ListaDeducciones.Add(oDeduccion);
        }
        public double calcularSalarioBruto()
        {
            double salario = 0;
            switch (formaPago)
            {
                case FormPago.MENSUAL:
                    salario = salarioBruto;
                    break;
                case FormPago.QUINCENAL:
                    salario = this.salarioBruto = 2;
                    break;
                case FormPago.SEMANAL:
                    salario = this.salarioBruto * 4.33;
                    break;

            }
            
            return salario;
        }

        public double aplicarDeducciones()
        {
            double salarioConDeduccion = this.salarioBruto;
            double porcentaje = 0;
            foreach (Deduccion d in this.ListaDeducciones)
            {
                porcentaje += d.porcentaje;


            }
            salarioConDeduccion = salarioConDeduccion - (salarioConDeduccion * porcentaje);
            return salarioConDeduccion;
        }
    }
}
