// Built from tag v2.4.0-rc-4

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
