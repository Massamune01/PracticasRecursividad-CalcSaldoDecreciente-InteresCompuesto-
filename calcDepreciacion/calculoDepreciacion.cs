namespace calcDepreciacion
{
    public class calculoDepreciacion
    {
        //Variables
        private double v = 0; // Costo Inicial
        private double d = 0; // Porcentaje   
        public int t { get; set; } // Tiempo en años
        private double r;// Factor de retención de valor 


        private int contador = 1; // Contador para el año


        public calculoDepreciacion()
        {
            //Variables
            Console.WriteLine("Ingrese el Costo Inicial:");
            v = inputToDouble(); // Costo Inicial

            Console.WriteLine("Ingrese el porcentaje:");
            d = inputToDouble(); // Porcentaje

            Console.WriteLine("Ingrese los años:");
            t = inputToInt(); // Tiempo en años

            r = 1 - d / 100; // Factor de retención de valor 
        }
        

        // Cálculo de Depreciación por Saldo Decreciente
        public double CalcDepreciacion(int T)
        {

            // Caso base
            if (T == 0)
            {
                //Informe
                Console.WriteLine($"Año 0: El valor actual es: ${Math.Round(v, 2)}");

                return v;
            }


            // Caso Recursivo (Estado Recursivo)
            if (T > 0)
            {

                v = CalcDepreciacion(T - 1) * r;
                System.Console.WriteLine($"Año {contador}: El valor actual es: ${Math.Round(v, 2)}");
                contador++;
            }

            return v;
        }

        private static int inputToInt() 
        {
            int input = 0;

            while (!int.TryParse(Console.ReadLine(), out input) && input >= 0)
            {
                Console.WriteLine("Introduzca una entrada valida y numero posi");
            }

            return input;
        }

        private static double inputToDouble()
        {
            double input = 0;

            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Introduzca una entrada valida");
            }

            return input;
        }

    }
}
