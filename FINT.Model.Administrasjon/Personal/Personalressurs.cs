using System;


using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{
	public class Personalressurs {
		public enum Relasjonsnavn
        {
			PARORENDE,
			PERSONALRESSURSKATEGORI,
			ARBEIDSFORHOLD
        }
        
	
		public Identifikator brukernavn { get; set; }
		public Identifikator systemId { get; set; }
		public Identifikator ansattnummer { get; set; }
		public Periode ansettelsesperiode { get; set; }
		public Kontaktinformasjon kontaktinformasjon { get; set; }
		
	}
}
