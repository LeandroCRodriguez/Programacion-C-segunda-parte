namespace Logica
{
    public class Empresa
    {
        string nombre;
        int cuit;
        List<Empleado> empleados;

        public Empresa(string nombre, int cuit, List<Empleado> empleados)
        {
            this.nombre = nombre;
            this.cuit = cuit;
            this.empleados = empleados;
        }

        public float CalcularMontototalSueldos()
        {
            float montoTotalSueldos = 0;
            foreach (Empleado empleado in empleados)
            {
                montoTotalSueldos += empleado.SueldoNeto();
            }
            return montoTotalSueldos;
        }
        public float CalcularMontototalSueldosBrutos()
        {
            float montoTotalSueldos = 0;
            foreach (Empleado empleado in empleados)
            {
                montoTotalSueldos += empleado.CalcularSueldoBruto();
            }
            return montoTotalSueldos;
        }
        public float CalcularMontototalSueldosRetenciones()
        {
            float montoTotalRetenciones = 0;
            foreach (Empleado empleado in empleados)
            {
                montoTotalRetenciones += empleado.CalcularRetenciones();
            }
            return montoTotalRetenciones;
        }
    }
}