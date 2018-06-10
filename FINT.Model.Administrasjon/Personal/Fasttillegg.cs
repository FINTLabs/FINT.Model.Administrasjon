// Built from tag v3.0.0

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Personal;

namespace FINT.Model.Administrasjon.Personal
{
	public class Fasttillegg : Lonn {
		public enum Relasjonsnavn
        {
			LONNSART,
			ANVISER,
			KONTERER,
			ATTESTANT,
			ARBEIDSFORHOLD
        }
        
	
		public long Belop { get; set; }
		
	}
}
