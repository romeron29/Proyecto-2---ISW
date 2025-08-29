using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTurno.Model
{
    public abstract class Personaje
    {
        // Propiedades protegidas para herencia
        protected string nombre { get; set; }
        protected int vida { get; set; }
        protected int energia { get; set; }
        protected int ataque { get; set; }
        protected int escudo { get; set; }

        // Propiedades públicas
        public Raza raza { get; set; }
        public List<Habilidad> Habilidades { get; set; } = new List<Habilidad>();

        // Constructor
        protected Personaje(string nombre, int vida, int energia, int ataque, int escudo, List<Habilidad> habilidades, Raza raza)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.energia = energia;
            this.ataque = ataque;
            this.escudo = escudo;
            Habilidades = habilidades ?? new List<Habilidad>();
            this.raza = raza;
        }

        // Métodos abstractos que deben ser implementados por las subclases
        public abstract void Atacar(Personaje enemigo);
        public abstract void Defender();
        public abstract void Curacion();

        // Método virtual para aplicar daño
        public virtual void Danno(int cantidad)
        {
            int dañoReal = Math.Max(0, cantidad - escudo);
            vida -= dañoReal;
            Console.WriteLine($"{nombre} recibió {dañoReal} de daño. Vida restante: {vida}");
        }

        // Método para usar una habilidad
        public virtual void UsarHabilidad(Habilidad habilidad, Personaje objetivo)
        {
          
        }

        // Mostrar estado actual del personaje
        public virtual string MostrarEstado()
        {
            return $"{nombre} ({raza?.nombre}) - Vida: {vida}, Energía: {energia}, Ataque: {ataque}, Escudo: {escudo}";
        }

        // Representación textual
        public override string ToString()
        {
            return MostrarEstado();
        }
    }
}