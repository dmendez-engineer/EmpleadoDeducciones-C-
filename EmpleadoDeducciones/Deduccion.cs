using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadoDeducciones
{
  public  class Deduccion
    {

        public String descripcionDeduccion { set; get; }
        public double porcentaje { set; get; }
        private static Deduccion instance = null;


        public Deduccion(String codigo, double por)
        {
            this.descripcionDeduccion = codigo;
            this.porcentaje = por;
        }
        public Deduccion()
        {
                
        }
        public static Deduccion getInstace()
        {
            if(instance == null)
            {
                instance = new Deduccion();
            }
            return instance;
        }
    }
}
