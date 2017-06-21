using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classes.cs
{
    public class Studenten
    {
        public int studentID { get; set; }
        public string voorNaam { get; set; }
        public string achterNaam { get; set; }
        public string fullName { get { return this.voorNaam + " " + this.achterNaam; } }

    }
}