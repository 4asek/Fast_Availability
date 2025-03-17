using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Box
    {
        public Guid Id { get; set; }
        public Guid ShipmentId { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public decimal Price { get; set; }
        public virtual Shipment Shipment { get; set; }
        //public Box()
        //{
        //   this.Id = Guid.NewGuid();
        //   this.Weight = 0;
        //   this.Height = 0;
        //   this.Width = 0;
        //   this.Price = 0;
        //}
        public Box(Shipment shipment)
        {
            this.Id = Guid.NewGuid();
            this.ShipmentId = shipment.Id; 
            this.Weight = 0;
            this.Height = 0;
            this.Width = 0;
            this.Price = 0;
            this.Shipment = shipment;
        }
    }
}
