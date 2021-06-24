using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.LogicaNegocio
{
   public class VehiculoServicioListModel
    {
        public int IdVehiculoServicio { get; set; }
       
        public int IdServicio { get; set; }
       
        public int IdVehiculo { get; set; }
        
    }
}
