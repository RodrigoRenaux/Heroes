using System;
namespace EFCore.WebAPI.Models
{
	public class Batalha
	{

        public int Id { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public DateTime DtInicio { get; set; }

        public DateTime DtFim { get; set; }

        public List<HeroiBatalha> HeroisBatalhas { get; set; }

    }
}

