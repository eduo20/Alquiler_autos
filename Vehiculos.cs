using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler_autos
{
    internal class Vehiculos
    {
        string placa;
        string marca;
        int modelo;
        decimal precio_kilometro;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public decimal Precio_kilometro { get => precio_kilometro; set => precio_kilometro = value; }
    }
}
