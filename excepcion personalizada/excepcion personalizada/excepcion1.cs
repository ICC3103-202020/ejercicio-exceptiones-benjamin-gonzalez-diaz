using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepcion_personalizada
{
    class InvalidacionNombreEstudiante : ApplicationException
    {
        public InvalidacionNombreEstudiante()
        {

        }
        public InvalidacionNombreEstudiante(string nombre)
            : base(string.Format("nombre del estudiante Invalido: {0}", nombre))
        {

        }
    }
}
