// Built from tag v0.99.9

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
