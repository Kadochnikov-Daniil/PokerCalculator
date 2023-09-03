using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class CardHandler
	{ 
		public Dictionary<string, Player> Players;
		public string[] TableCards;
		public List<string> UsedCards { get; }

		public CardHandler()
		{
			Players = new Dictionary<string, Player>();
			TableCards = new string[5] { "BackSide", "BackSide", "BackSide", "BackSide", "BackSide" };
			UsedCards = new List<string>();
		}

		public void AddPlayer(string name)
		{
			Players.Add(name, new Player());
		}

		public void RemovePlayer(string name)
		{
			Players.Remove(name);
		}
	}
}
