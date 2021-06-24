using CapaAccesoDatos;
using CapaEntidad.Entities;
using CapaLogicaNegocio.LogicaNegocio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.Servicios
{
    public class VehiculoServicio
    {
        private readonly WashCarDBContext washCarDBContext;

        public VehiculoServicio(WashCarDBContext washCarDBContext)
        {
            this.washCarDBContext = washCarDBContext;
        }

        public async Task<VehiculoListModel> GetOnlyVehiculoByAsync(int id)
        {
            return await washCarDBContext.Vehiculos.Select(
                vehiculo => new VehiculoListModel
                {
                    IdVehiculo = vehiculo.IdVehiculo,
                    Placa = vehiculo.Placa,
                    Dueno = vehiculo.Dueno,
                    Marca = vehiculo.Marca

                }).FirstOrDefaultAsync(vehiculo => vehiculo.IdVehiculo == id);
        }

        public async Task<List<VehiculoListModel>> GetAllVehiculosByAsync()
        {
            return await washCarDBContext.Vehiculos.Select(
                vehiculo => new VehiculoListModel
                {
                    IdVehiculo = vehiculo.IdVehiculo,
                    Placa = vehiculo.Placa,
                    Dueno = vehiculo.Dueno,
                    Marca = vehiculo.Marca
                }).ToListAsync();
        }

        public async Task InsertVehiculoAsync(VehiculoListModel vehiculo)
        {
            Vehiculo entity = new Vehiculo()
            {     
                Placa = vehiculo.Placa,
                Dueno = vehiculo.Dueno,
                Marca = vehiculo.Marca
            };

            washCarDBContext.Vehiculos.Add(entity);
            await washCarDBContext.SaveChangesAsync();
        }
    }
}

