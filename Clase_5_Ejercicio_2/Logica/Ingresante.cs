using System.Text;

namespace Logica
{
    public class Ingresante
    {
        List<String> cursos;
        string direccion;
        int edad;
        string genero;
        string nombre;
        string pais;

        public Ingresante(List<string> cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dirección: "+this.direccion);
            sb.AppendLine("Edad: "+this.edad.ToString());
            sb.AppendLine("Género: "+this.genero);
            sb.AppendLine("Nombre: "+this.nombre);
            sb.AppendLine("País: "+this.pais);
            sb.AppendLine("Cursos: ");
            foreach (var curso in cursos)
            {
                sb.AppendLine(curso);
            }
            return sb.ToString();
        }
    }
}