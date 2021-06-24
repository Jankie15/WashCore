using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Hosting;
using CapaLogicaNegocio.Servicios;
using CapaLogicaNegocio.LogicaNegocio;

namespace CapaPresentacion.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
		private readonly VehiculoServicio vehiculoServicio;
		
		public DefaultViewModel(VehiculoServicio vehiculoServicio)
		{
			this.vehiculoServicio = vehiculoServicio;
			
		}

		public List<VehiculoListModel> Vehiculo { get; set; }

		public override async Task PreRender()
        {
			Vehiculo = await vehiculoServicio.GetAllVehiculosByAsync();
			await base.PreRender();

		}
    }
}
