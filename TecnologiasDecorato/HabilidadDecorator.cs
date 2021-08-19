using Civiles;
using ComportamientoCivil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecnologiasDecorato
{
    public abstract class HabilidadDecorator : Ciudadano
    {
        protected HabilidadDecorator(IAtacarBehavior atacarBehavior, ITrabajoBehavior trabajoBehavior) : base(atacarBehavior, trabajoBehavior)
        {
        }
        public override abstract string GetDescription();
    }
}
