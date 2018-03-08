// Built from tag v0.99.9

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Kompleksedatatyper;
using FINT.Model.Administrasjon.Personal;

namespace FINT.Model.Administrasjon.Personal
{
	public class Variabellonn : Lonn {
		public enum Relasjonsnavn
        {
			ANVISER,
			KONTERER,
			ATTESTANT,
			ARBEIDSFORHOLD
        }
        
	
		public List<Variabelttillegg> Variabelttillegg { get; set; }
		
	}
}
