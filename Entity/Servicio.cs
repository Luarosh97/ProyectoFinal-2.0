using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio
    {
        public int Codigo {get;set;}
        public string Nombre {get; set;}
         public decimal Base {get;set;} 
       
  
        public Servicio()
        {
            this.Base = 0;
            this.Codigo = 0;
            this.Nombre = "";
          }

        public Servicio(int Codigo)
        {
            this.Base = 0;
            this.Codigo = Codigo;
            this.Nombre = "";
           }

        public Servicio(string nombre, decimal valor)
        { 
            this.Codigo = 0; 
            this.Nombre = nombre;
          this.Base = valor;
        }

        public Servicio(int codigo, string nombre, decimal valor)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Base = valor;
        }


    }
}
