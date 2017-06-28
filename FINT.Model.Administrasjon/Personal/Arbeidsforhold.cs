using System;


using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{
	public class Arbeidsforhold {
		public enum Relasjonsnavn
        {
			ANSVAR,
			ARBEIDSFORHOLDSTYPE,
			FUNKSJON,
			STILLINGSKODE,
			TIMERPERUKE,
			ARBEIDSSTED,
			UNDERVISNINGSFORHOLD,
			PERSONALRESSURS
        }
        
	
		public Identifikator systemId { get; set; }
		public string stillingsnummer { get; set; }
		public Periode gyldighetsperiode { get; set; }
		public double arslonn { get; set; }
		public string stillingstittel { get; set; }
		public double ansettelsesprosent { get; set; }
		public double lonnsprosent { get; set; }
		public bool hovedstilling { get; set; }
		
	}
}
