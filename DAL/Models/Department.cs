using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //з'язки йоу
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Shipment> SentShipments { get; set; }
        public virtual ICollection<Shipment> ReceivedShipments { get; set; }
    }
}
