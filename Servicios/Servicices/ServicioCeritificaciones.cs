using DTOs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicices
{
    public interface IServicioCertificaciones
    {
        IEnumerable<Certificaciones> Certificaciones();
    }
    public class ServicioCeritificaciones : IServicioCertificaciones
    {


        public IEnumerable<Certificaciones> Certificaciones()
        {

            var certificaciones = new List<Certificaciones>
            {

                new Certificaciones
                {
                    Titulo = "ASP.net 5 EntityFramework",
                    Foto = "ASP.net_Core5.jpg",
                    Centro = "Universidad O&M"

                },
                new Certificaciones
                {
                    Titulo = "SQL Server 2019",
                    Foto = "Sqlserver2019.jpg",
                    Centro = "Udemy"

                },
                new Certificaciones
                {
                    Titulo = "Desarrollo Web JavaScript Moderno ",
                    Foto = "Javascript2018.jpg",
                    Centro = "Udemy"

                }
            };

            return certificaciones;
        }
    }
}
