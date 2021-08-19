using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamientoCivil.TareasCiviles
{
    public class RepararBehavior : ITrabajoBehavior
    {
        public void Trabajar(double recursos)
        {
            Console.WriteLine("El reparador está reparando");
        }
    }
}
