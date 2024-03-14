using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    class Alquiler
    {
        string nit;
        string placa;
        DateTime fechaAlquiler;
        DateTime fechaDevolución;
        decimal kilómetrosRecorridos;

        public string Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public DateTime FechaDevolución { get => fechaDevolución; set => fechaDevolución = value; }
        public decimal KilómetrosRecorridos { get => kilómetrosRecorridos; set => kilómetrosRecorridos = value; }
    }
}
