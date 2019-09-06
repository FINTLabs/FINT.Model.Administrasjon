// Built from tag v3.3.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{
	public class Fravar {
		public enum Relasjonsnavn
        {
			FRAVARSGRUNN,
			FRAVARSTYPE,
			ARBEIDSFORHOLD,
			FORTSETTELSE,
			FORTSETTER
        }
        
	
		public Periode Periode { get; set; }
		public long Prosent { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
