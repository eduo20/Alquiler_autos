using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_autos
{
    internal class Reporte
    {
        string nombre;
        string plac;
        string marc;
        int mod;
        decimal precio_km;
        DateTime fecha_devolucion;
        decimal kilometros;
        decimal total;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Plac { get => plac; set => plac = value; }
        public string Marc { get => marc; set => marc = value; }
        public int Mod { get => mod; set => mod = value; }
        public decimal Precio_km { get => precio_km; set => precio_km = value; }
        public DateTime Fecha_devolucion { get => fecha_devolucion; set => fecha_devolucion = value; }
        public decimal Kilometros { get => kilometros; set => kilometros = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
