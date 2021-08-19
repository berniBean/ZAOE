using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamientoCivil
{
    public class ConstruirBehavior : ITrabajoBehavior
    {
        public void Trabajar(double _recursos)
        {
            Console.WriteLine("El Constructor construye edificios con: "+ _recursos +" de velocidad");
        }
    }
}
