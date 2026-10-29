using System;

namespace calcDepreciacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            interesCompuesto interesCom = new interesCompuesto();

            interesCom.CalcDepreciacion(interesCom.t);
        }
    }
}