using System;

namespace calcDepreciacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculoDepreciacion depreciacion = new calculoDepreciacion();

            depreciacion.CalcDepreciacion(depreciacion.t);
        }
    }
}