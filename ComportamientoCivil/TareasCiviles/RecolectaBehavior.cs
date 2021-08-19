using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComportamientoCivil.TareasCiviles
{
    public class RecolectaBehavior : ITrabajoBehavior
    {
        

        public void Trabajar(double _recurso)
        {
            Console.WriteLine("El aldeano recolecta con: "+_recurso+" de velocidad");
        }

    }
}
