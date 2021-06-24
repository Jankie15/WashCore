using CapaAccesoDatos;
using CapaLogicaNegocio.LogicaNegocio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Servicios
{
   public class ServicioServicio
    {
        private readonly WashCarDBContext washCarDBContext;

        public ServicioServicio(WashCarDBContext washCarDBContext)
        {
            this.washCarDBContext = washCarDBContext;
        }

        public async Task<ServicioListModel> GetOnlyServicioByAsync(int id)
        {
            return await washCarDBContext.Servicios.Select(
                servicio => new ServicioListModel
                {
                    IdServicio = servicio.IdServicio,
                    Descripcion = servicio.Descripcion,
                    Monto = servicio.Monto
                }).FirstOrDefaultAsync(servicio => servicio.IdServicio == id);
        }

        public async Task<List<ServicioListModel>> GetAllServiciosByAsync()
        {
            return await washCarDBContext.Servicios.Select(
                servicio => new ServicioListModel
                {
                    IdServicio = servicio.IdServicio,
                    Descripcion = servicio.Descripcion,
                    Monto = servicio.Monto
                }).ToListAsync();
        }

        public async Task InsertServicioAsync(ServicioListModel servicio)
        {
            var entity = new CapaEntidad.Entities.Servicio()
            {
               
                Descripcion = servicio.Descripcion,
                Monto = servicio.Monto
            };

            washCarDBContext.Servicios.Add(entity);
            await washCarDBContext.SaveChangesAsync();
        }
    }
}

