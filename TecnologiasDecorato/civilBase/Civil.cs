using Civiles;
using ComportamientoCivil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnologiasDecorato.civilBase
{
    public class Civil : Ciudadano
    {
        
        public Civil(IAtacarBehavior atacarBehavior, ITrabajoBehavior trabajoBehavior) : base(atacarBehavior, trabajoBehavior)
        {
            
        }

        public override double alcance()
        {
            return 0;
        }

        public override double antiProyectil()
        {
            return 0;
        }

        public override double armadura()
        {
            return 0;
        }

        public override double ataque()
        {
            return 3;
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override double recurso()
        {
            return 0;
        }

        public override double resistencia()
        {
            return 25;
        }

        public override double velocidad()
        {
            return .8;
        }

        public override double velocidadAtaque()
        {
            return 2.03;
        }

        public override double vision()
        {
            return 4;
        }
    }
}
