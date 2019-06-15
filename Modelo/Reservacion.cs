using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Reservacion
    {
        public int Reservacion { get; set; }
        public Huesped huesped { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public int CantidadNoches { get; set; }
        public int CantidadAdultos { get; set; }
        public int CantidadInfantes { get; set; }
        public string Canal { get; set; }
        public string Comentario { get; set; }
        public float PrecioPorCantidadNoches { get; set; }

        public Reservacion(int Reservacion, Huesped huesped, DateTime FechaLlegada, DateTime FechaSalida, DateTime FechaCancelacion,
            )
        {

        }
    }
}
