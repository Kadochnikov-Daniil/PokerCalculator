using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace WPFUI.ViewModel
{
	public class CardViewModel : ViewModelBase
	{
		//Fields
		private string cardName;

		//Properties
		public string CardName
		{
			get
			{
				return cardName;
			}
			set
			{
				cardName = value;
				OnPropertyChanged(nameof(CardName));
			}
		}

		//Commands
		public ICommand PlaceCardCommand { get; }

		public CardViewModel()
		{
			PlaceCardCommand = new ViewModelCommand(ExecutePlaceCardCommand);
			ExecutePlaceCardCommand("BackSide");
		}

		private void ExecutePlaceCardCommand(object arg)
		{
			if (arg is string card)
			{
				CardName = "/Images/Cards/" + card + ".png";
			}
		}
	}
}
