namespace Prueba
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 1;
            int numeroDos = 2;
            Numero numeroTres = 3;
            MetodoLoco(numeroUno);
            MetodoLoco(out numeroDos);
            MetodoLoco(numeroTres);

            Console.WriteLine("{0},{1},{2}", numeroUno,numeroDos,numeroTres.NumeroLoco);
        //1,14,3
        }
        public static void MetodoLoco(int numero)
        {
            numero = 14;
        }
        public static void MetodoLoco(out int numero)
        {
            numero = 14;
        }
        public static void MetodoLoco(Numero numero)
        {
            numero.NumeroLoco = 14;
        }
    }
}