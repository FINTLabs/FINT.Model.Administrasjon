// Built from tag v3.1.0

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Personal;

namespace FINT.Model.Administrasjon.Personal
{
	public class Variabellonn : Lonn {
		public enum Relasjonsnavn
        {
			LONNSART,
			ANVISER,
			KONTERER,
			ATTESTANT,
			ARBEIDSFORHOLD
        }
        
	
		public long Antall { get; set; }
		public long? Belop { get; set; }
		
	}
}
