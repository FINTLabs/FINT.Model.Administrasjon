using System;


using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Administrasjon.Organisasjon
{
	public class Organisasjonselement : Enhet {
		public enum Relasjonsnavn
        {
			LEDER,
			OVERORDNET,
			SKOLE,
			UNDERORDNET
        }
        
	
		public string navn { get; set; }
		public string kortnavn { get; set; }
		public Identifikator organisasjonsId { get; set; }
		public Identifikator organisasjonsKode { get; set; }
		public Periode gyldighetsperiode { get; set; }
		
	}
}
