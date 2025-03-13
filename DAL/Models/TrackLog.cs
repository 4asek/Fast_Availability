using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class TrackLog
    {
        [Key]
        public Guid TrackId { get; set; }
        public string Message { get; set; }
        public double ProceedTime { get; set; }
        public ICollection<Shipment> Shipment { get; set; }
    }
}
