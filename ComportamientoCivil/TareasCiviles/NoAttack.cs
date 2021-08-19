using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamientoCivil.TareasCiviles
{
    public class NoAttack : IAtacarBehavior
    {
        public void Atacar(double _ataque)
        {
            Console.WriteLine("El aldeano no ataca");
        }
    }
}
