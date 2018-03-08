// Built from tag v0.99.9

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Kompleksedatatyper
{
	public class Variabelttillegg {
		public enum Relasjonsnavn
        {
			LONNSART,
			KONTOSTRENG
        }
        
	
		public long Antall { get; set; }
		public long? Belop { get; set; }
		public string Beskrivelse { get; set; }
		public Periode Periode { get; set; }
		
	}
}
