using FintFellesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintAdministrasjonModel.Model.Personal
{
    public class Personalressurs
    {
        public Identifikator brukernavn { get; set; }
        public Identifikator systemId { get; set; }
        public Identifikator ansattnummer { get; set; }
        public Periode ansettelsesperiode { get; set; }
        public Kontaktinformasjon kontaktinformasjon { get; set; }
    }
}
