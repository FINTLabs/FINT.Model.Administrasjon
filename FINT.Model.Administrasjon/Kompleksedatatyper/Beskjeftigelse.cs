// Built from tag v0.99.9

using System;
using System.Collections.Generic;



namespace FINT.Model.Administrasjon.Kompleksedatatyper
{
	public class Beskjeftigelse {
		public enum Relasjonsnavn
        {
			LONNSART,
			KONTOSTRENG
        }
        
	
		public string Beskrivelse { get; set; }
		public long Prosent { get; set; }
		
	}
}
