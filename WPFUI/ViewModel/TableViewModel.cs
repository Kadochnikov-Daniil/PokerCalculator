using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFUI.ViewModel;
using Model;


namespace WPFUI.ViewModel
{
	public class TableViewModel : ViewModelBase
	{
		//fields
		private CardHandler myModel;

		private ViewModelBase firstCard;
		private ViewModelBase secondCard;
		private ViewModelBase thirdCard;
		private ViewModelBase fourthCard;
		private ViewModelBase fifthCard;

		private ViewModelBase playerOne;
		private ViewModelBase playerTwo;
		private ViewModelBase playerThree;
		private ViewModelBase playerFour;
		private ViewModelBase playerFive;
		private ViewModelBase playerSix;
		private ViewModelBase playerSeven;
		private ViewModelBase playerEight;
		private ViewModelBase playerNine;
		private ViewModelBase playerTen;

		//properties
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

		public ViewModelBase ThirdCard
		{
			get
			{
				return thirdCard;
			}
			set
			{
				thirdCard = value;
				OnPropertyChanged(nameof(ThirdCard));
			}
		}

		public ViewModelBase FourthCard
		{
			get
			{
				return fourthCard;
			}
			set
			{
				fourthCard = value;
				OnPropertyChanged(nameof(FourthCard));
			}
		}

		public ViewModelBase FifthCard
		{
			get
			{
				return fifthCard;
			}
			set
			{
				fifthCard = value;
				OnPropertyChanged(nameof(FifthCard));
			}
		}

		public ViewModelBase PlayerOne
		{
			get
			{
				return playerOne;
			}
			set
			{
				playerOne = value;
				OnPropertyChanged(nameof(PlayerOne));
			}
		}
		public ViewModelBase PlayerTwo
		{
			get
			{
				return playerTwo;
			}
			set
			{
				playerTwo = value;
				OnPropertyChanged(nameof(PlayerTwo));
			}
		}

		public ViewModelBase PlayerThree
		{
			get
			{
				return playerThree;
			}
			set
			{
				playerThree = value;
				OnPropertyChanged(nameof(PlayerThree));
			}
		}

		public ViewModelBase PlayerFour
		{
			get
			{
				return playerFour;
			}
			set
			{
				playerFour = value;
				OnPropertyChanged(nameof(PlayerFour));
			}
		}

		public ViewModelBase PlayerFive
		{
			get
			{
				return playerFive;
			}
			set
			{
				playerFive = value;
				OnPropertyChanged(nameof(PlayerFive));
			}
		}

		public ViewModelBase PlayerSix
		{
			get
			{
				return playerSix;
			}
			set
			{
				playerSix = value;
				OnPropertyChanged(nameof(PlayerSix));
			}
		}

		public ViewModelBase PlayerSeven
		{
			get
			{
				return playerSeven;
			}
			set
			{
				playerSeven = value;
				OnPropertyChanged(nameof(PlayerSeven));
			}
		}

		public ViewModelBase PlayerEight
		{
			get
			{
				return playerEight;
			}
			set
			{
				playerEight = value;
				OnPropertyChanged(nameof(PlayerEight));
			}
		}

		public ViewModelBase PlayerNine
		{
			get
			{
				return playerNine;
			}
			set
			{
				playerNine = value;
				OnPropertyChanged(nameof(PlayerNine));
			}
		}

		public ViewModelBase PlayerTen
		{
			get
			{
				return playerTen;
			}
			set
			{
				playerTen = value;
				OnPropertyChanged(nameof(PlayerTen));
			}
		}

		//Commands
		public ICommand AddPlayerOne { get; }
		public ICommand AddPlayerTwo { get; }
		public ICommand AddPlayerThree { get; }
		public ICommand AddPlayerFour { get; }
		public ICommand AddPlayerFive { get; }
		public ICommand AddPlayerSix { get; }
		public ICommand AddPlayerSeven { get; }
		public ICommand AddPlayerEight { get; }
		public ICommand AddPlayerNine { get; }
		public ICommand AddPlayerTen { get; }

		public ICommand RemovePlayerOne { get; }
		public ICommand RemovePlayerTwo { get; }
		public ICommand RemovePlayerThree { get; }
		public ICommand RemovePlayerFour { get; }
		public ICommand RemovePlayerFive { get; }
		public ICommand RemovePlayerSix { get; }
		public ICommand RemovePlayerSeven { get; }
		public ICommand RemovePlayerEight { get; }
		public ICommand RemovePlayerNine { get; }
		public ICommand RemovePlayerTen { get; }

		public TableViewModel()
		{
			AddPlayerOne = new ViewModelCommand(ExecuteAddPlayerOne);
			AddPlayerTwo = new ViewModelCommand(ExecuteAddPlayerTwo);
			AddPlayerThree = new ViewModelCommand(ExecuteAddPlayerThree);
			AddPlayerFour = new ViewModelCommand(ExecuteAddPlayerFour);
			AddPlayerFive = new ViewModelCommand(ExecuteAddPlayerFive);
			AddPlayerSix = new ViewModelCommand(ExecuteAddPlayerSix);
			AddPlayerSeven = new ViewModelCommand(ExecuteAddPlayerSeven);
			AddPlayerEight = new ViewModelCommand(ExecuteAddPlayerEight);
			AddPlayerNine = new ViewModelCommand(ExecuteAddPlayerNine);
			AddPlayerTen = new ViewModelCommand(ExecuteAddPlayerTen);

			RemovePlayerOne = new ViewModelCommand(ExecuteRemovePlayerOne);
			RemovePlayerTwo = new ViewModelCommand(ExecuteRemovePlayerTwo);
			RemovePlayerThree = new ViewModelCommand(ExecuteRemovePlayerThree);
			RemovePlayerFour = new ViewModelCommand(ExecuteRemovePlayerFour);
			RemovePlayerFive = new ViewModelCommand(ExecuteRemovePlayerFive);
			RemovePlayerSix = new ViewModelCommand(ExecuteRemovePlayerSix);
			RemovePlayerSeven = new ViewModelCommand(ExecuteRemovePlayerSeven);
			RemovePlayerEight = new ViewModelCommand(ExecuteRemovePlayerEight);
			RemovePlayerNine = new ViewModelCommand(ExecuteRemovePlayerNine);
			RemovePlayerTen = new ViewModelCommand(ExecuteRemovePlayerTen);

			myModel = new CardHandler();

			FirstCard = new CardViewModel();
			SecondCard = new CardViewModel();
			ThirdCard = new CardViewModel();
			FourthCard = new CardViewModel();
			FifthCard = new CardViewModel();

			ExecuteAddPlayerOne(null);
			ExecuteAddPlayerSix(null);
		}

		private void ExecuteAddPlayerTen(object obj)
		{
			myModel.AddPlayer("PlayerTen"); 
			PlayerTen = new PlayerViewModel();		
		}
		private void ExecuteAddPlayerNine(object obj)
		{
			myModel.AddPlayer("PlayerNine");
			PlayerNine = new PlayerViewModel();
		}

		private void ExecuteAddPlayerEight(object obj)
		{
			myModel.AddPlayer("PlayerEight"); 
			PlayerEight = new PlayerViewModel();
		}
		private void ExecuteAddPlayerSeven(object obj)
		{
			myModel.AddPlayer("PlayerSeven");
			PlayerSeven = new PlayerViewModel();
		}
		private void ExecuteAddPlayerSix(object obj)
		{
			myModel.AddPlayer("PlayerSix"); 
			PlayerSix = new PlayerViewModel();
		}
		private void ExecuteAddPlayerFive(object obj)
		{
			myModel.AddPlayer("PlayerFive"); 
			PlayerFive = new PlayerViewModel();
		}
		private void ExecuteAddPlayerFour(object obj)
		{
			myModel.AddPlayer("PlayerFour"); 
			PlayerFour = new PlayerViewModel();
		}
		private void ExecuteAddPlayerThree(object obj)
		{
			myModel.AddPlayer("PlayerThree"); 
			PlayerThree = new PlayerViewModel();
		}
		private void ExecuteAddPlayerTwo(object obj)
		{
			myModel.AddPlayer("PlayerTwo"); 
			PlayerTwo = new PlayerViewModel();
		}
		private void ExecuteAddPlayerOne(object obj)
		{
			myModel.AddPlayer("PlayerOne"); 
			PlayerOne = new PlayerViewModel();
		}

		private void ExecuteRemovePlayerTen(object obj)
		{
			PlayerTen = null;
			myModel.RemovePlayer("PlayerTen");
		}
		private void ExecuteRemovePlayerNine(object obj)
		{
			PlayerNine = null;
			myModel.RemovePlayer("PlayerNine");
		}
		private void ExecuteRemovePlayerEight(object obj)
		{
			PlayerEight = null;
			myModel.RemovePlayer("PlayerEight");
		}
		private void ExecuteRemovePlayerSeven(object obj)
		{
			PlayerSeven = null;
			myModel.RemovePlayer("PlayerSeven");
		}
		private void ExecuteRemovePlayerSix(object obj)
		{
			PlayerSix = null;
			myModel.RemovePlayer("PlayerSix");
		}
		private void ExecuteRemovePlayerFive(object obj)
		{
			PlayerFive = null;
			myModel.RemovePlayer("PlayerFive");
		}
		private void ExecuteRemovePlayerFour(object obj)
		{
			PlayerFour = null;
			myModel.RemovePlayer("PlayerFour");
		}
		private void ExecuteRemovePlayerThree(object obj)
		{
			PlayerThree = null;
			myModel.RemovePlayer("PlayerThree");
		}
		private void ExecuteRemovePlayerTwo(object obj)
		{
			PlayerTwo = null;
			myModel.RemovePlayer("PlayerTwo");
		}
		private void ExecuteRemovePlayerOne(object obj)
		{
			PlayerOne = null;
			myModel.RemovePlayer("PlayerOne");
		}
	}
}
