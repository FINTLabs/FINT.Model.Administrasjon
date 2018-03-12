// Built from tag v2.6.0-beta-3

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Kompleksedatatyper
{
	public class Fasttillegg {
		public enum Relasjonsnavn
        {
			LONNSART
        }
        
	
		public long Belop { get; set; }
		public string Beskrivelse { get; set; }
		public Kontostreng Kontostreng { get; set; }
		
	}
}
