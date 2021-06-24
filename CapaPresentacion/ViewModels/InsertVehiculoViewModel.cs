using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogicaNegocio.LogicaNegocio;
using CapaLogicaNegocio.Servicios;
using DotVVM.Framework.ViewModel;

namespace CapaPresentacion.ViewModels
{
    public class InsertVehiculoViewModel : MasterPageViewModel
    {
        private readonly VehiculoServicio vehiculoServicio;

       public InsertVehiculoViewModel(VehiculoServicio vehiculoServicio)
        {
            this.vehiculoServicio = vehiculoServicio;
        }

        public VehiculoListModel Vehiculo { get; set; } = new VehiculoListModel { };
        public async Task InsertVehiculo()
        {
            await vehiculoServicio.InsertVehiculoAsync(Vehiculo);
            Context.RedirectToRoute("Default");
        }
    }


}

