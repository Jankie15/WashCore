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
    public class ListVehiculosServiciosViewModel : MasterPageViewModel
    {
        private readonly VehiculoServicioServicio vehiculoServicioServicio;

        public ListVehiculosServiciosViewModel(VehiculoServicioServicio vehiculoServicioServicio)
        {
            this.vehiculoServicioServicio = vehiculoServicioServicio;
        }

        public List<VehiculoServicioListModel> VehiculoServico { get; set; }

        public override async Task PreRender()
        {
            VehiculoServico = await vehiculoServicioServicio.GetAllVehiculosServiciosByAsync();
            await base.PreRender();
        }
    }
}

