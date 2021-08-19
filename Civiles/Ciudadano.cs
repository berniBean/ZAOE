using ComportamientoCivil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiles
{
    public abstract class Ciudadano
    {
        protected IAtacarBehavior _atacarBehavior;
        protected ITrabajoBehavior _trabajoBehavior;

        protected double _resistencia;
        protected double _ataque;
        protected double _bonificaciones;
        protected double _velocidad;
        protected double _velocidadAtaque;
        protected double _alcande;
        protected double _armas;
        protected double _antiProyectil;
        protected double _vision;
        protected double _recursos;
        protected double _armadura;
        protected string _description = "Stats: ";
        public abstract double armadura();
        public abstract double resistencia();
        public abstract double ataque();
        public abstract double velocidad();
        public abstract double velocidadAtaque();
        public abstract double alcance();
        public abstract double antiProyectil();
        public abstract double vision();
        public abstract double recurso();

        public virtual string GetDescription()
        {
            return _description;
        }

        public Ciudadano(IAtacarBehavior atacarBehavior, ITrabajoBehavior trabajoBehavior)
        {
            _atacarBehavior = atacarBehavior;
            _trabajoBehavior = trabajoBehavior;
        }
        public abstract void Display();
        public void desplazar()
        {
            Console.WriteLine($"Se desplaza ${_velocidad}");
        }

        public void performTrabajo()
        {
            _trabajoBehavior.Trabajar(recurso());
        }

        public void performAtaque()
        {
            _atacarBehavior.Atacar(ataque());
        }

        
        
    }
}
