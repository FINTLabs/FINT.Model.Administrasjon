// Built from tag v3.0.0-rc-1

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Kompleksedatatyper;
using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{
	public abstract class Lonn {
	
		public DateTime? Anvist { get; set; }
		public DateTime? Attestert { get; set; }
		public string Beskrivelse { get; set; }
		public DateTime? Kontert { get; set; }
		public Kontostreng Kontostreng { get; set; }
		public Periode Opptjent { get; set; }
		public Periode Periode { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
