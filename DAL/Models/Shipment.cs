using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Shipment
    {
        public Guid Id { get; set; }
        public Guid DepartmentSenderId { get; set; }
        public Guid DepartmentReceiverId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime DepartureDate { get; set; }
        public Guid ClientId { get; set; }
        public Guid TrackId { get; set; }


        //навігатори до раю
        public virtual Department DepartmentSender { get; set; }
        public virtual Department DepartmentReceiver { get; set; }
        public virtual TrackLog TrackLog { get; set; }
        public ICollection<Clients> Clients { get; set; }
        public ICollection<Box> Boxes { get; set; }
        public Shipment() 
        {
        
        }
    }
}
