using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    class Reporte
    {
        string nombreCliente;
        string placa;
        string marca;
        string modelo;
        string color;
        DateTime fechaDevolución;
        decimal totalPagar;

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public DateTime FechaDevolución { get => fechaDevolución; set => fechaDevolución = value; }
        public decimal TotalPagar { get => totalPagar; set => totalPagar = value; }
    }
}
