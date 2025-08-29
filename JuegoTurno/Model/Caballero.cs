using JuegoTurno.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTurno.Model
{
    public class Caballero : Personaje
    {
        public int Fuerza { get; set; }

        public Caballero(string nombre, int vida, int energia, int ataque, int escudo, List<Habilidad> habilidades, Raza raza, int fuerza)
            : base(nombre, vida, energia, ataque, escudo, habilidades, raza)
        {
            Fuerza = fuerza;
        }

        public override void Atacar(Personaje enemigo)
        {
            int daño = ataque + (Fuerza / 2);
            enemigo.Danno(daño);
            Console.WriteLine($"{nombre} ataca con su espada. Daño causado: {daño}");
        }

        public override void Defender()
        {
            escudo += 3;
            Fuerza += 2;
            Console.WriteLine($"{nombre} se defiende con su escudo. Escudo +3, Fuerza +2");
        }

        public override void Curacion()
        {
            vida += 12;
            Console.WriteLine($"{nombre} se recupera. Vida +12");
        }
        public override string ToString()
        {
            return $" Fuerza: {Fuerza}, nombre: {nombre}, vida: {vida}, energia: {energia}";
        }
    }
}
