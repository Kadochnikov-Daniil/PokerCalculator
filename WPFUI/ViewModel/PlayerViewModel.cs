using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFUI.ViewModel
{
	internal class PlayerViewModel : ViewModelBase
	{
		//fields
		private string name;
		private ViewModelBase firstCard;
		private ViewModelBase secondCard;
		private string winRate;

		//properties
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
				OnPropertyChanged(nameof(Name));
			}
		}

		public ViewModelBase FirstCard
		{
			get
			{
				return firstCard;
			}
			set
			{
				firstCard = value;
				OnPropertyChanged(nameof(FirstCard));
			}
		}

		public ViewModelBase SecondCard
		{
			get
			{
				return secondCard;
			}
			set
			{
				secondCard = value;
				OnPropertyChanged(nameof(SecondCard));
			}
		}

		public string WinRate
		{
			get
			{
				return winRate;
			}
			set
			{
				winRate = value;
				OnPropertyChanged(nameof(WinRate));
			}
		}

		public PlayerViewModel() 
		{
			FirstCard = new CardViewModel();
			SecondCard = new CardViewModel();
			Name = "Player";
			WinRate = "-";
		}
	}
}
 