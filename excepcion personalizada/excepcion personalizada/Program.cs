using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace excepcion_personalizada
{
    class Program
    {
        static void Main(string[] args)
        {
            estudiante newEstudiante = null;

            try
            {
                newEstudiante = new estudiante();
                newEstudiante.NombreEstudiante = "mario64";

                ValidateEstudiante(newEstudiante);
            }
            catch (InvalidacionNombreEstudiante ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
        private static void ValidateEstudiante(estudiante std)
        {
            Regex reg = new Regex("^[a-zA-Z]+$");

            if (!reg.IsMatch(std.NombreEstudiante))
                throw new InvalidacionNombreEstudiante(std.NombreEstudiante);
        }
    }
}
