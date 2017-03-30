using FintFellesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintAdministrasjonModel.Model.Personal
{
    public class Arbeidsforhold
    {
        public Identifikator SystemId { get; set; }
        public string stillingsnummer { get; set; }
        public bool aktiv { get; set; }
        public double arslonn { get; set; }
        public string stillingstittel { get; set; }
        public double ansettelsesprosent { get; set; }
        public double lonnsprosent { get; set; }
        public bool hovedstilling { get; set; }
        public Periode gyldighetsperiode { get; set; }
        public Kontaktinformasjon kontaktinformasjon { get; set; }

    }
}
