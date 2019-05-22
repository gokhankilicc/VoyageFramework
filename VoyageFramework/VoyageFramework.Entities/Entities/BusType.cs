using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework.DAL.Entities;

namespace VoyageFramework.Entities.Entities
{
    public class BusType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusTypeId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public bool HasToilet { get; set; }
    }
}
