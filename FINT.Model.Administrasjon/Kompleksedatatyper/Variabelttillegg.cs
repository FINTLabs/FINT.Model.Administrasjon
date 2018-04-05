// Built from tag v2.7.0

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Kompleksedatatyper;
using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Kompleksedatatyper
{
	public class Variabelttillegg {
		public enum Relasjonsnavn
        {
			LONNSART
        }
        
	
		public long Antall { get; set; }
		public long? Belop { get; set; }
		public string Beskrivelse { get; set; }
		public Kontostreng Kontostreng { get; set; }
		public Periode Periode { get; set; }
		
	}
}
