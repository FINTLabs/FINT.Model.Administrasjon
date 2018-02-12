// Built from tag v2.6.0-beta-1

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
