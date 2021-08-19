using ComportamientoCivil;
using ComportamientoCivil.TareasCiviles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiles.TiposObreros
{
    public class Inactivo : Ciudadano
    {
        public Inactivo(IAtacarBehavior atacarBehavior, ITrabajoBehavior trabajoBehavior) : base(atacarBehavior, trabajoBehavior)
        {
            atacarBehavior = new NoAttack();
            trabajoBehavior = new NoWorker();
        }

        public override double alcance()
        {
            return _alcande;
        }

        public override double antiProyectil()
        {
            return _antiProyectil;
        }

        public override double armadura()
        {
            return _armadura;
        }

        public override double ataque()
        {
            return _ataque;
        }
        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override double recurso()
        {
            return _recursos;
        }

        public override double resistencia()
        {
            return _resistencia;
        }

        public override double velocidad()
        {
            return _velocidad;
        }

        public override double velocidadAtaque()
        {
            return _velocidadAtaque;
        }

        public override double vision()
        {
            return _vision;
        }
    }
}
