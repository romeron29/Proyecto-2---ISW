using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTurno.Model
{
    public class Arquero : Personaje
    {
        public int Punteria { get; set; }

        public Arquero(string nombre, int vida, int energia, int ataque, int escudo, List<Habilidad> habilidades, Raza raza, int punteria)
            : base(nombre, vida, energia, ataque, escudo, habilidades, raza)
        {
            Punteria = punteria;
        }

        public override void Atacar(Personaje enemigo)
        {
            int daño = ataque + Punteria;
            enemigo.Danno(daño);
            Console.WriteLine($"{nombre} dispara una flecha precisa. Daño: {daño}");
        }

        public override void Defender()
        {
            escudo += 2;
            Punteria += 3;
            Console.WriteLine($"{nombre} se posiciona estratégicamente. Escudo +2, Puntería +3");
        }

        public override void Curacion()
        {
            vida += 10;
            Console.WriteLine($"{nombre} se recupera rápidamente. Vida +10");
        }
    }
}
