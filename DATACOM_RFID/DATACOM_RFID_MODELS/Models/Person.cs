using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATACOM_RFID_MODELS.Models
{
   public class Person
    {
        public int PersonID { get; set; }
        public string Naam { get; set; }
        public string  Voornaam { get; set; }
        public string Gemeente { get; set; }
        public string  Club { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Geslacht { get; set; }
        public string Gehakt { get; set; }

        //test
    }
}
