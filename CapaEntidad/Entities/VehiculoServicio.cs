﻿using System;
using System.Collections.Generic;

namespace CapaEntidad.Entities
{
    public partial class VehiculoServicio
    {
        public int IdVehiculoServicio { get; set; }
        public int IdServicio { get; set; }
        public int IdVehiculo { get; set; }

        public virtual Servicio IdServicioNavigation { get; set; }
        public virtual Vehiculo IdVehiculoNavigation { get; set; }
    }
}
