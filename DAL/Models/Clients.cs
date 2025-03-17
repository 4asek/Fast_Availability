using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Clients
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; }
        public Guid ShipmentId { get; set; }
        public virtual Shipment Shimpment { get; set; }
        public Clients() 
        {
            this.Id = Guid.NewGuid();
            this.FirstName = "Your Name";
            this.LastName = "Your LastName";
            
        }
    }
}
