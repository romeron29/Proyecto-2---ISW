using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuegoTurno.Interface;

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
        public List<Habilidad> Habilidades { get; set; }

        // Constructor
        protected Personaje(string nombre, int vida, int energia, int ataque, int escudo, List<Habilidad> habilidades, Raza raza)
        {
            this.raza = raza;
            this.nombre = nombre ;
            this.vida = vida + raza.vidaBase;
            this.energia = energia +raza.energiaBase;
            this.ataque = ataque + raza.ataqueBase;
            this.escudo = escudo + raza.escudoBase;
            Habilidades = habilidades;
            
        }

        // Métodos abstractos que deben ser implementados por las subclases
        public abstract void Atacar(Personaje enemigo);
        public abstract void Defender();
        public abstract void Curacion();

        // Método virtual para aplicar daño
        public virtual void Danno(int cantidad)
        {
            int dannoReal = Math.Max(0, cantidad - escudo);
            vida -= dannoReal;
            Console.WriteLine($"{nombre} recibió {dannoReal} de daño. Vida restante: {vida}");
        }

        // Método para usar una habilidad
        public virtual void UsarHabilidad(Habilidad habilidad, Personaje objetivo)
        {
          
        }

        // Mostrar estado actual del personaje
        public virtual string MostrarEstado()
        {
            string habilidades = "";
            foreach (var habilidad in Habilidades)
            {
                habilidades += habilidad.ToString() + "\n";
            }
            return $"{nombre} ({raza?.nombre}) - Vida: {vida}, Energía: {energia}, Ataque: {ataque}, Escudo: {escudo}, Habilidades: {habilidades}";
        }

        // Representación textual
        public override string ToString()
        {
            return MostrarEstado();
        }
    }
}