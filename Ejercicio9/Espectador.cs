using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Espectador
    {
        string nombre;
        int edad;
        double dinero;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Dinero { get => dinero; set => dinero = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }


        public Espectador (string nombrePa, int edadPa, double dineroPa)
        {
            Nombre = nombrePa;
            edad = edadPa;
            Dinero = dineroPa;
        }
    }
}
