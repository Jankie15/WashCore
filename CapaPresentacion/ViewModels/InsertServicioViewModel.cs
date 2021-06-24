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
    public class InsertServicioViewModel : MasterPageViewModel
    {
        private readonly ServicioServicio servicioServicio;

        public InsertServicioViewModel(ServicioServicio servicioServicio)
        {
            this.servicioServicio = servicioServicio;
        }

        public ServicioListModel Servicio { get; set; } = new ServicioListModel { };

        public async Task InsertServicio()
        {
            await servicioServicio.InsertServicioAsync(Servicio);
            Context.RedirectToRoute("List_Servicios");
        }

    }
}

