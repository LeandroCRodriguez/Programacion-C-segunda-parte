using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Empleado
    {
        string nombre;
        int Dirección;
        bool EstadoCivil;
        DateTime fechaNacimiento;
        float SueldoBasico;
        float ret = 0.0f;

        protected Empleado(string nombre, int dirección, bool estadoCivil, 
            DateTime fechaNacimiento, float sueldoBasico, float ret)
        {
            this.nombre = nombre;
            Dirección = dirección;
            EstadoCivil = estadoCivil;
            this.fechaNacimiento = fechaNacimiento;
            SueldoBasico = sueldoBasico;
            this.ret = ret;
        }

        public DateTime CalcularEdad(DateTime fechaNacimiento)
        {
            return fechaNacimiento;
        }

        public abstract float CalcularSueldoBruto();


        public abstract float CalcularRetenciones();


        public abstract float SueldoNeto();
        


    }

    
}
