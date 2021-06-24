using CapaAccesoDatos;
using CapaLogicaNegocio.LogicaNegocio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Servicios
{
   public class VehiculoServicioServicio
    {
        private readonly WashCarDBContext washCarDBContext;
        public VehiculoServicioServicio(WashCarDBContext washCarDBContext)
        {
            this.washCarDBContext = washCarDBContext;
        }

        public async Task<VehiculoServicioListModel> GetOnlyVehiculoServicioByAsync(int id)
        {
            return await washCarDBContext.VehiculoServicios.Select(
                vehiculoServicio => new VehiculoServicioListModel
                {
                    IdVehiculoServicio = vehiculoServicio.IdVehiculoServicio,
                    IdServicio = vehiculoServicio.IdServicio,
                    IdVehiculo = vehiculoServicio.IdVehiculo,


                }).FirstOrDefaultAsync(vehiculoServicio => vehiculoServicio.IdVehiculoServicio == id);
        }

        public async Task<List<VehiculoServicioListModel>> GetAllVehiculosServiciosByAsync()
        {

            return await washCarDBContext.VehiculoServicios.Select(
                vehiculoServicio => new VehiculoServicioListModel
                {
                    IdVehiculoServicio = vehiculoServicio.IdVehiculoServicio,
                    IdServicio = vehiculoServicio.IdServicio,
                    IdVehiculo = vehiculoServicio.IdVehiculo,

                }).ToListAsync();

        }

        public async Task InsertVehiculoAsync(VehiculoServicioListModel vehiculoServicio)
        {
            var entity = new CapaEntidad.Entities.VehiculoServicio()
            {
                
                IdServicio = vehiculoServicio.IdServicio,
                IdVehiculo = vehiculoServicio.IdVehiculo,

            };

            washCarDBContext.VehiculoServicios.Add(entity);
            await washCarDBContext.SaveChangesAsync();
        }
    }
}

