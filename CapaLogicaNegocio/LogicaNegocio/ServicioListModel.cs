using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio.LogicaNegocio
{
    public class ServicioListModel
    {
        public int IdServicio { get; set; }
       
        public string Descripcion { get; set; }
       
        public int Monto { get; set; }
       
    }
}
