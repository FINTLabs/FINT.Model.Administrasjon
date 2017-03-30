using FintFellesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintAdministrasjonModel.Model.Organisasjon
{
    public class Organisasjonselement : Enhet
    {
        public string Navn { get; set; }
        public string Kortnavn { get; set; }
        public bool Aktiv { get; set; }
        public Identifikator OrganisasjonsId { get; set; }
        public Identifikator OrganisasjonsKode { get; set; }
        public Periode Gyldighetsperiode { get; set; }
    }
}
