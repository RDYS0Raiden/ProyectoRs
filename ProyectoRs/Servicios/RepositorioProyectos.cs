using ProyectoRs.Models;

namespace ProyectoRs.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo="CHURASQUERIA1",
                Descripcion="pagina para buscar una churasqueria",
                Link="https://www.boliviaentusmanos.com/restaurantes-gastronomia/1/churrasquerias.html",
                ImagenURL="/imagenes/brangus1.png"
            },
                 new Proyecto
            {
                Titulo="CHURASQUERIA2",
                Descripcion="churrasqueria en todo bolivia",
                Link="https://amarillas.bo/rubro/churrasquerias",
                ImagenURL="/imagenes/brangus2.png"
            },
                  new Proyecto
            {
                Titulo="Proccimo Proyecto",
                Descripcion="Proyecto en proceso",
                Link="",
                ImagenURL="/imagenes/brangus3.png"
            },
                new Proyecto
            {
                Titulo="Proccimo Proyecto",
                Descripcion="proyecto en proceso",
                Link="https://www.google.com",
                ImagenURL="/imagenes/brangus1.png"
            },
            };
        }
    }
}
