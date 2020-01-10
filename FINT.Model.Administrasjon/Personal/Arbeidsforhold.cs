// Built from tag v3.4.0

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
			ART,
			FUNKSJON,
			STILLINGSKODE,
			TIMERPERUKE,
			ARBEIDSSTED,
			PERSONALLEDER,
			FASTLONN,
			FASTTILLEGG,
			FRAVAR,
			LONN,
			VARIABELLONN,
			PERSONALRESSURS,
			UNDERVISNINGSFORHOLD
        }
        
	
		public long Ansettelsesprosent { get; set; }
		public long Arslonn { get; set; }
		public Periode Gyldighetsperiode { get; set; }
		public bool Hovedstilling { get; set; }
		public long Lonnsprosent { get; set; }
		public string Stillingsnummer { get; set; }
		public string Stillingstittel { get; set; }
		public Identifikator SystemId { get; set; }
		public long Tilstedeprosent { get; set; }
		
	}
}
