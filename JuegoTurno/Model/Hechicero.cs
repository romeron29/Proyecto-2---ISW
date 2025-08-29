using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTurno.Model
{
    public class Hechicero : Personaje
    {
        public int Mana { get; set; }

        public Hechicero(string nombre, int vida, int energia, int ataque, int escudo, List<Habilidad> habilidades, Raza raza, int mana)
            : base(nombre, vida, energia, ataque, escudo, habilidades, raza)
        {
            Mana = mana;
        }

        public override void Atacar(Personaje enemigo)
        {
            int daño = ataque + (Mana / 3);
            enemigo.Danno(daño);
            Console.WriteLine($"{nombre} lanza un hechizo. Daño mágico: {daño}");
        }

        public override void Defender()
        {
            escudo += 2;
            Mana += 5;
            Console.WriteLine($"{nombre} activa un escudo mágico. Escudo +2, Mana +5");
        }

        public override void Curacion()
        {
            if (Mana >= 5)
            {
                vida += 15;
                Mana -= 5;
                Console.WriteLine($"{nombre} usa magia curativa. Vida +15, Mana -5");
            }
            else
            {
                Console.WriteLine($"{nombre} no tiene suficiente mana para curarse.");
            }
        }
    }
}
