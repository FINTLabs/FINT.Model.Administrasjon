// Built from tag v2.4.0

using System;
using System.Collections.Generic;



namespace FINT.Model.Administrasjon.Kompleksedatatyper
{
	public class Fasttillegg {
		public enum Relasjonsnavn
        {
			LONNSART,
			KONTOSTRENG
        }
        
	
		public long Belop { get; set; }
		public string Beskrivelse { get; set; }
		
	}
}
