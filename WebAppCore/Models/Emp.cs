using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAppCore.Models
{
    public partial class Emp
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Edesign { get; set; }
        public DateTime? Edoj { get; set; }
    }
}
