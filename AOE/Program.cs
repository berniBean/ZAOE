using Civiles;
using Civiles.TiposObreros;
using ComportamientoCivil;
using ComportamientoCivil.TareasCiviles;
using System;
using TecnologiasDecorato.civilBase;
using TecnologiasDecorato.Teconologias;

namespace AOE
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ciudadano model = new Civil(new NoAttack(), new NoWorker());
            model = new Aldeano(new AtacarBehavior(), new NoWorker(), model);
            Console.WriteLine(model.GetDescription() + " " + model.resistencia() + " Resistencia " + model.ataque() + " Ataque " + model.velocidad() + " Velocidad " + model.vision() + " Vision ");
            model.Display();
            model.performTrabajo();
            model.performAtaque();

            model = new Civil(new NoAttack(), new NoWorker());
            Console.WriteLine(model.GetDescription() + " " + model.resistencia() + " Resistencia " + model.ataque() + " Ataque " + model.velocidad() + " Velocidad " + model.vision() + " Vision ");
            model = new Telar(new AtacarBehavior(), new NoWorker(), model);
            Console.WriteLine(model.GetDescription() + " " + model.resistencia() + " Resistencia " + model.ataque() + " Ataque " + model.velocidad() + " Velocidad " + model.vision() + " Vision ");
            model = new Carretilla(new AtacarBehavior(), new NoWorker(), model);
            Console.WriteLine(model.GetDescription() + " " + model.resistencia() + " Resistencia " + model.ataque() + " Ataque " + model.velocidad() + " Velocidad " + model.vision() + " Vision ");
            model = new CarroDeMano(new AtacarBehavior(), new NoWorker(), model);
            Console.WriteLine(model.GetDescription() + " " + model.resistencia() + " Resistencia " + model.ataque() + " Ataque " + model.velocidad() + " Velocidad " + model.vision() + " Vision ");

            model = new Cantero(new NoAttack(), new RecolectaBehavior(),model);
            model.Display();
            model.performAtaque();
            model.performTrabajo();
            Console.WriteLine(model.GetDescription() + " " + model.resistencia() + " Resistencia " + model.ataque() + " Ataque " + model.velocidad() + " Velocidad " + model.vision() + " Vision ");

            model = new Granjero(new NoAttack(), new RecolectaBehavior(), model);
            model.Display();
            model.performAtaque();
            model.performTrabajo();
            Console.WriteLine(model.GetDescription() + " " + model.resistencia() + " Resistencia " + model.ataque() + " Ataque " + model.velocidad() + " Velocidad " + model.vision() + " Vision ");

            model = new Cazador(new AtacarBehavior(), new RecolectaBehavior(), model);
            model.Display();
            model.performAtaque();
            model.performTrabajo();
            Console.WriteLine(model.GetDescription() + " " + model.resistencia() + " Resistencia " + model.ataque() + " Ataque " + model.velocidad() + " Velocidad " + model.vision() + " Vision ");

 
        }
    }
}
