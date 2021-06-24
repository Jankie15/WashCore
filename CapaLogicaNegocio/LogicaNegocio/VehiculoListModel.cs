using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.LogicaNegocio
{
   public class VehiculoListModel
    {
        public int IdVehiculo { get; set; }
       
        public string Placa { get; set; }
       
        public string Dueno { get; set; }
       
        public string Marca { get; set; }
       
    }
}
