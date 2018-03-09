// Built from tag v2.6.0-beta-2

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Kompleksedatatyper
{
	public class Beskjeftigelse {
		public enum Relasjonsnavn
        {
			LONNSART
        }
        
	
		public string Beskrivelse { get; set; }
		public Kontostreng Kontostreng { get; set; }
		public long Prosent { get; set; }
		
	}
}
