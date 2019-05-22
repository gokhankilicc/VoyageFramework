using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework.DAL.Entities
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }      
        public decimal PaidAmount { get; set; }

        public BusExpedition BusExpedition { get; set; }
        public SeatInformation SeatInformation { get; set; }
        public Person Person { get; set; }
    }
}
