using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamientoCivil.TareasCiviles
{
    public class AtacarBehavior : IAtacarBehavior
    {
        
        public void Atacar(double _ataque)
        {
            Console.WriteLine("El aldeano está atacando con: "+_ataque+" de daño");
        }


    }
}
