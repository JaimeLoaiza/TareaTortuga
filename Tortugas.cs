using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTortuga
{
    public class Tortugas
    {
        private string nombre;
        private string especie;
        private string clasificacion;
        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string Nombre)
        {
            this.nombre = Nombre;
        }
        public string Especie
        {
            get
            {
                return this.especie;
            }
            set
            {
                this.especie = value;
            }
        }
        public string Clasificacion
        {
            get
            {
                return this.clasificacion;
            }
            set
            {
                this.clasificacion = value;
            }
        }
    }
}
