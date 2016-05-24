using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseHeryPol.Herencia
{
    public class Profesores
    {
        private string _Nombre;
        private string _Apellido;
        private int _Materias;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        public int Materias
        {
            get { return _Materias; }
        }
    }
}
