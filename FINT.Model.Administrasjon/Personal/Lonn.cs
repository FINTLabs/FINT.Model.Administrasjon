// Built from tag v3.3.0

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Administrasjon.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Personal
{
	public abstract class Lonn {
	
		public DateTime? Anvist { get; set; }
		public DateTime? Attestert { get; set; }
		public string Beskrivelse { get; set; }
		public Identifikator KildesystemId { get; set; }
		public DateTime? Kontert { get; set; }
		public Kontostreng Kontostreng { get; set; }
		public Periode Opptjent { get; set; }
		public Periode Periode { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
