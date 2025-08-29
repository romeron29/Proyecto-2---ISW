using JuegoTurno.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTurno.Model
{
    public class Habilidad : IHabilidad
    {
        public string Nombre { get; set; }
        public int CostoEnergia { get; set; }
        public string Descripcion { get; set; }

        public Habilidad(string nombre, int costoEnergia, string descripcion)
        {
            Nombre = nombre;
            CostoEnergia = costoEnergia;
            Descripcion = descripcion;
        }

        public void usarHabilidad(Personaje usuario, Personaje objetivo)
        {
            
        }

        // Método virtual para aplicar la habilidad


        public override string ToString()
        {
            return $"{Nombre} (Costo: {CostoEnergia}) - {Descripcion}";
        }
    }

}
