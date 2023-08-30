using System;
namespace EFCore.WebAPI.Models
{
	public class IdentidadeSecreta
	{
		public int Id { get; set; }

		public String NomeReal { get; set; }

        public int HeroiId { get; set; }

		public Heroi Heroi { get; set; }

    }
}

