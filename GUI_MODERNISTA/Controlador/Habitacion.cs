using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA.Controlador
{
    class Habitacion       
    {
        private int id;
        private string numHabitacion;
        private string tipoHabitacion;
        private int numCamas;
        private int numMaxPersonas;
        private int piso;
        private string estado;
        private string plan;
        private string detalles;
        private float precio;

        public Habitacion(int id, string numHabitacion, string tipoHabitacion, int numCamas, int numMaxPersonas, int piso, string estado, string plan, string detalles, float precio)
        {
            this.Id = id;
            this.NumHabitacion = numHabitacion;
            this.TipoHabitacion = tipoHabitacion;
            this.NumCamas = numCamas;
            this.NumMaxPersonas = numMaxPersonas;
            this.Piso = piso;
            this.Estado = estado;
            this.Plan = plan;
            this.Detalles = detalles;
            this.Precio = precio;
        }
        
        public int Id { get => id; set => id = value; }
        public string NumHabitacion { get => numHabitacion; set => numHabitacion = value; }
        public string TipoHabitacion { get => tipoHabitacion; set => tipoHabitacion = value; }
        public int NumCamas { get => numCamas; set => numCamas = value; }
        public int NumMaxPersonas { get => numMaxPersonas; set => numMaxPersonas = value; }
        public int Piso { get => piso; set => piso = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Plan { get => plan; set => plan = value; }
        public string Detalles { get => detalles; set => detalles = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}
