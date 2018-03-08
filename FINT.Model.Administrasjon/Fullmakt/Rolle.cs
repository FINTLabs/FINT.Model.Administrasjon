// Built from tag v0.99.9

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Fullmakt
{
	public class Rolle {
		public enum Relasjonsnavn
        {
			FULLMAKT
        }
        
	
		public string Beskrivelse { get; set; }
		public Identifikator Navn { get; set; }
		
	}
}
