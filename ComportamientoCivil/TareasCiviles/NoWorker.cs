using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamientoCivil.TareasCiviles
{
    public class NoWorker : ITrabajoBehavior
    {
        public void Trabajar(double recurso)
        {
            Console.WriteLine("El aldeano no trabaja");
        }
    }
}
