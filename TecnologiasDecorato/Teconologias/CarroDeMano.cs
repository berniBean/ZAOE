using Civiles;
using ComportamientoCivil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnologiasDecorato.Teconologias
{
    public class CarroDeMano : HabilidadDecorator
    {
        Ciudadano _ciudadano;
        public CarroDeMano(IAtacarBehavior atacarBehavior, ITrabajoBehavior trabajoBehavior, Ciudadano ciudadano) : base(atacarBehavior, trabajoBehavior)
        {
            _ciudadano = ciudadano;
        }

        public override double alcance()
        {
            return _ciudadano.alcance() + 0;
        }

        public override double antiProyectil()
        {
            return _ciudadano.antiProyectil() + 0;
        }

        public override double armadura()
        {
            return _ciudadano.armadura();
        }

        public override double ataque()
        {
            return _ciudadano.ataque() + 0;
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
            return _ciudadano.recurso() + (_ciudadano.recurso() * .50);
        }

        public override double resistencia()
        {
            return _ciudadano.resistencia() + 0;
        }

        public override double velocidad()
        {
            return _ciudadano.velocidad() + (_ciudadano.velocidad() * .10);
        }

        public override double velocidadAtaque()
        {
            return _ciudadano.velocidadAtaque() + 0;
        }

        public override double vision()
        {
            return _ciudadano.vision() + 0;
        }
    }
}
