using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework.DAL.Entities
{
    public class BusExpedition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusExpeditionId { get; set; }                   
        public bool HasSnackService { get; set; }
        public DateTime DepartureTime { get; set; }

        public Bus Bus { get; set; }
        public Driver Driver { get; set; }
        public Host Host { get; set; }



    }
}
