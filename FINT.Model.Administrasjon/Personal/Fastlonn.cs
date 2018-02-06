// Built from tag v2.4.0

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Kompleksedatatyper;
using FINT.Model.Administrasjon.Personal;

namespace FINT.Model.Administrasjon.Personal
{
	public class Fastlonn : Lonn {
		public enum Relasjonsnavn
        {
			ANVISER,
			KONTERER,
			ATTESTANT,
			ARBEIDSFORHOLD
        }
        
	
		public List<Beskjeftigelse> Beskjeftigelse { get; set; }
		public List<Fasttillegg> Fasttillegg { get; set; }
		
	}
}
