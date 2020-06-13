using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado : Persona
    {
        public string Cargo { get; set; }
        public DateTime FechaIngreso {get;set;}

     public Empleado(string identificacion, string cargo , DateTime fechaIngreso, string cedula, string nombre, string apellidos, string telefono, string correo)
            : base(identificacion,cedula, nombre, apellidos, telefono, correo )
        {
       
        }

        public Empleado()
        {

        }

        public Empleado(string identificacion)
        {
            this.Identificacion = identificacion;
        }
    }
}
