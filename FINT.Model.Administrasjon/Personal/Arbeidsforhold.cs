// Built from tag v3.1.0

using System;
using System.Collections.Generic;



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
			PERSONALLEDER,
			FRAVAR,
			LONN,
			PERSONALRESSURS,
			UNDERVISNINGSFORHOLD
        }
        
	
		public long Ansettelsesprosent { get; set; }
		public Periode Gyldighetsperiode { get; set; }
		public bool Hovedstilling { get; set; }
		public long Lonnsprosent { get; set; }
		public string Stillingsnummer { get; set; }
		public string Stillingstittel { get; set; }
		public Identifikator SystemId { get; set; }
		public long Tilstedeprosent { get; set; }
		public long Arslonn { get; set; }
		
	}
}
