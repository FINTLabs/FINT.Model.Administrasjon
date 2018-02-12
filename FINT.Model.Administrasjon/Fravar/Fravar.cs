// Built from tag v2.6.0-beta-1

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Fravar
{
	public class Fravar {
		public enum Relasjonsnavn
        {
			FRAVARSTYPE,
			FRAVARSGRUNN,
			ARBEIDSFORHOLD,
			FORTSETTELSE,
			FORTSETTER
        }
        
	
		public Periode Periode { get; set; }
		public long Prosent { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
