using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyageFramework.DAL.Entities;

namespace Voyage.Entity
{
    public class ExpeditionHostPoco
    {
        public BusExpedition BusExpedition { get; set; }
        public Host Host { get; set; }
    }
}
