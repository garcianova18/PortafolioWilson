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
    public class ServicioProyectos : IServicioProyectos
    {
        public ServicioProyectos()
        {

        }

        public IEnumerable<Proyectos> Proyectos()
        {

            var proyectos = new List<Proyectos>()
            {
                new Proyectos
                {
                    Titulo="RESTful API Sistema de Facturacion",
                    Descripcion="Esta es un API para un sistema de facturacion creada con .NET 6.0",
                    Imagen ="APIRestful_Facturacion.png",
                    Url="https://github.com/garcianova18/SistemaFacturacion"

                },
                new Proyectos
                {
                    Titulo="Sistema de Gestion de Averia",
                    Descripcion="Esta es un aplicacion web para un sistema de gestion creada con ASP.NET Core 3.1",
                    Imagen ="GesinV2.png",
                    Url="https://github.com/garcianova18/Gesin-V2"

                },
                new Proyectos
                {
                    Titulo="Agenda Telefonica",
                    Descripcion="En ella almacenamos los contacto de los usuarios, Creada en ASP.NET Core 3.1",
                    Imagen ="AgendaTelefonica.JPG",
                    Url="http://www.agendacgi.somee.com/Electromecanica"
                   
                },
                 new Proyectos
                {
                    Titulo="Blog Personal",
                    Descripcion="Esta es un blog donde creo contenido de programacion y de tecnologia en general, creado en ASP.NET 7.0",
                    Imagen ="blog.png",
                    Url="https://github.com/garcianova18/BlogPersonal"
                },
                    new Proyectos
                {
                    Titulo="Api Movie",
                    Descripcion="Consumiendo la API themoviedb para mostrar mostrar las peliculas mas populares hasta la fecha, creado en ASP.NET 6.0",
                    Imagen ="Api_pelicula.png",
                    Url="https://github.com/garcianova18/ConsumienAPiPeliculas"
                },
                  new Proyectos
                {
                    Titulo="User Ramdom",
                    Descripcion="Consumiendo la API randomuser para mostrar tarjetas con usuarios y hacer uso de paginación, creado en ASP.NET 6.0",
                    Imagen ="randomuserAPI.png",
                    Url="https://github.com/garcianova18/ConsumiendoWebAPI"
                }
                
            };



            return proyectos;
        }


    }
}
