using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_autos
{
    internal class Alquiler
    {
        string nit;
        string placa_auto;
        DateTime fecha_alquiler;
        DateTime fecha_devolucion;
        decimal kilometros_recorridos;

        public string Nit { get => nit; set => nit = value; }
        public string Placa_auto { get => placa_auto; set => placa_auto = value; }
        public DateTime Fecha_alquiler { get => fecha_alquiler; set => fecha_alquiler = value; }
        public DateTime Fecha_devolucion { get => fecha_devolucion; set => fecha_devolucion = value; }
        public decimal Kilometros_recorridos { get => kilometros_recorridos; set => kilometros_recorridos = value; }
    }
}
