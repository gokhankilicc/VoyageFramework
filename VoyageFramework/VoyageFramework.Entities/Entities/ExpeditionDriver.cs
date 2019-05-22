using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework.DAL.Entities;

namespace Voyage.Entity
{
    public class ExpeditionDriverPoco
    {
        public BusExpedition BusExpedition { get; set; }
        public Driver Driver { get; set; }
    }
}
