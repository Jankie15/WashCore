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
    public class ListServiciosViewModel : MasterPageViewModel
    {
        private readonly ServicioServicio servicioServicio;

        public ListServiciosViewModel(ServicioServicio servicioServicio)
        {
            this.servicioServicio = servicioServicio;
        }

        public List<ServicioListModel> Servicio { get; set; }

        public override async Task PreRender()
        {
            Servicio = await servicioServicio.GetAllServiciosByAsync();
            await base.PreRender();
        }
    }
}

