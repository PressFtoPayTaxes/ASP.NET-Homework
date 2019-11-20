using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControlWork.Models
{
    public class Order : Entity
    {
        public virtual Client Client{ get; set; }
        public virtual Driver? Driver { get; set; }

        public double DestinationLongitude { get; set; }
        public double DestinationLatitude { get; set; }

        public double ClientLongitude { get; set; }
        public double ClientLatitude { get; set; }
        public Time Time { get; set; } = Time.NearestTime;
        public Tariff Tariff { get; set; } = Tariff.Econom;
        public Demands Demands { get; set; } = Demands.None;
        public string Comment { get; set; }
        public OrderState State { get; set; } = OrderState.Free;
    }
}