// Built from tag v3.4.0-rc-1

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Personal;

namespace FINT.Model.Administrasjon.Personal
{
	public class Fasttillegg : Lonn {
		public enum Relasjonsnavn
        {
			LONNSART,
			ARBEIDSFORHOLD,
			ANVISER,
			KONTERER,
			ATTESTANT
        }
        
	
		public long Belop { get; set; }
		
	}
}
