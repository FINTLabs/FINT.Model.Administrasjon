// Built from tag v2.6.0-beta-1

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
