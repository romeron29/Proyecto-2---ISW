using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTurno.Model
{
    public class Raza
    {


        public string nombre { get; set; }
        public int vidaBase { get; set; }
        public int energiaBase { get; set; }
        public int ataqueBase { get; set; }
        public int escudoBase { get; set; }
        public List<Habilidad> HabilidadesIniciales { get; set; } = new List<Habilidad>();

        public Raza(string nombre, int vidaBase, int energiaBase, int ataqueBase, int escudoBase, List<Habilidad> habilidadesIniciales)
        {
            this.nombre = nombre;
            this.vidaBase = vidaBase;
            this.energiaBase = energiaBase;
            this.ataqueBase = ataqueBase;
            this.escudoBase = escudoBase;
            HabilidadesIniciales = habilidadesIniciales ?? new List<Habilidad>();
        }

        public override string ToString()
        {
            return $"{nombre} - Vida: {vidaBase}, Energía: {energiaBase}, Ataque: {ataqueBase}, Escudo: {escudoBase}";
        }
    }

}

