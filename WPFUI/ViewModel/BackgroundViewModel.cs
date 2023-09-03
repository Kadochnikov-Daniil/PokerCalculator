using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.ViewModel
{
	public class BackgroundViewModel : ViewModelBase
	{
		//Fields
		private ViewModelBase tableView;

		//Properties
		public ViewModelBase TableView
		{
			get
			{
				return tableView;
			}
			set
			{
				tableView = value;
				OnPropertyChanged(nameof(TableView));
			}
		}

		public BackgroundViewModel() 
		{
			TableView = new TableViewModel();
		}		
	}
}
