using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinorPlanetsAPI.Models
{
    public class AstroidEsentialInfo
    {
        public float rms { get; set; }
        public string epoch { get; set; }
        public string readable_des { get; set; }
    }
}