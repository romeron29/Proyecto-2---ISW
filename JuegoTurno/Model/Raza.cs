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
        public Habilidad HabilidadUnica { get; set; }

        public Raza(string nombre, Habilidad habilidadUnica )
        {
            this.nombre = nombre;
            this.HabilidadUnica = habilidadUnica;
            this.vidaBase = 100;
            this.energiaBase = 100;
            this.ataqueBase = 50;
            this.escudoBase = 50;
            
        }

        public override string ToString()
        {
            return $"{nombre} - Vida: {vidaBase}, Energía: {energiaBase}, Ataque: {ataqueBase}, Escudo: {escudoBase}";
        }
    }

}

