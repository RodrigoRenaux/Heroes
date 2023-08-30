﻿using System;
namespace EFCore.WebAPI.Models
{
	public class Heroi
	{
		public int Id { get; set; }

        public String Nome { get; set; }

        public IdentidadeSecreta Identidade { get; set; }

        public List<Arma> Armas{ get; set; }

        public List<HeroiBatalha> HeroisBatalhas { get; set; }

    }
}

