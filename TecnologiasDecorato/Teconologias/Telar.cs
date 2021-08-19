using Civiles;
using ComportamientoCivil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnologiasDecorato.Teconologias
{
    public class Telar : HabilidadDecorator
    {
        Ciudadano _ciudadano;
        public Telar(IAtacarBehavior atacarBehavior, ITrabajoBehavior trabajoBehavior, Ciudadano ciudadano) : base(atacarBehavior, trabajoBehavior)
        {
            _ciudadano = ciudadano;
        }

        public override double alcance()
        {
            return _ciudadano.alcance();
        }

        public override double antiProyectil()
        {
            return _ciudadano.antiProyectil() + 2;
        }

        public override double armadura()
        {
            return _ciudadano.armadura() + 1;
        }

        public override double ataque()
        {
            return _ciudadano.ataque();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override string GetDescription()
        {
            return _ciudadano.GetDescription();
        }

        public override double recurso()
        {
            return _ciudadano.recurso();
        }

        public override double resistencia()
        {
            return _ciudadano.resistencia() +15;
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
