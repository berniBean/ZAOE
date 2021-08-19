using ComportamientoCivil;
using ComportamientoCivil.TareasCiviles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiles.TiposObreros
{
    public class Constructor : Ciudadano
    {
        Ciudadano _ciudadano;
        public Constructor(IAtacarBehavior atacarBehavior, ITrabajoBehavior trabajoBehavior, Ciudadano ciudadano) : base(atacarBehavior, trabajoBehavior)
        {
            atacarBehavior = new NoAttack();
            trabajoBehavior = new ConstruirBehavior();
            _ciudadano = ciudadano;
        }

        public override double alcance()
        {
            return _ciudadano.alcance();
        }

        public override double antiProyectil()
        {
            return _ciudadano.antiProyectil();
        }

        public override double armadura()
        {
            return _ciudadano.armadura();
        }

        public override double ataque()
        {
            return _ciudadano.ataque();
        }

        public override void Display()
        {
            Console.WriteLine("Construir");
        }

        public override double recurso()
        {
            return _ciudadano.recurso();
        }

        public override double resistencia()
        {
            return _ciudadano.resistencia();
        }

        public override double velocidad()
        {
            return _ciudadano.velocidad();
        }

        public override double velocidadAtaque()
        {
            return _ciudadano.velocidadAtaque();
        }

        public override double vision()
        {
            return _ciudadano.vision();
        }
    }
}
