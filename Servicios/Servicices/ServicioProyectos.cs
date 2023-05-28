using DTOs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicices
{
    public interface IServicioProyectos
    {
        IEnumerable<Proyectos> Proyectos();
    }
    public class ServicioProyectos: IServicioProyectos
    {
        public ServicioProyectos()
        {

        }

        public IEnumerable<Proyectos> Proyectos()
        {

            IEnumerable<Proyectos> proyectos = new List<Proyectos>()
            {


                new Proyectos
                {
                    Titulo="Agenda Telefonica",
                    Descripcion="En ella almacenamos los contacto de los usuarios, Creada en asp.net core 3.1",
                    Imagen ="AgendaTelefonica.JPG",
                    Url="http://www.agendacgi.somee.com/Electromecanica"
                },
                 new Proyectos
                {
                    Titulo="Blog Personal",
                    Descripcion="Esta es un blog donde subo contenido de programacion y de tecnologia en general",
                    Imagen ="blog.png",
                    Url="https://github.com/garcianova18/BlogPersonal"
                },
                  new Proyectos
                {
                    Titulo="User Ramdom",
                    Descripcion="Consumiendo la API randomuser para mostrar tarjetas con usuarios y hacer uso de paginación",
                    Imagen ="randomuserAPI.png",
                    Url="https://github.com/garcianova18/ConsumiendoWebAPI"
                }
            };



            return proyectos;
        }


    }
}
