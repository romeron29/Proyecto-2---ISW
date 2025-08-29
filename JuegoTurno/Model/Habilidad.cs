using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTurno.Model
{
    public class Habilidad
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

        // Método virtual para aplicar la habilidad
        public virtual string UtilizarHabilidad(Personaje usuario, Personaje objetivo)
        {
            return $"{usuario.MostrarEstado()} usa {Nombre} contra {objetivo.MostrarEstado()}";
        }

        public override string ToString()
        {
            return $"{Nombre} (Costo: {CostoEnergia}) - {Descripcion}";
        }
    }

}
