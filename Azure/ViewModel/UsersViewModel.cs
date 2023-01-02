using Azure.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.ViewModel
{
	public class UsersViewModel
	{
		public ObservableCollection<UsersDTO> Names { get; set; }
		private UsersService _users;

		public UsersViewModel()
		{
			_users = new UsersService();
			Load();

		}

		private void Load()
		{
			Names = new ObservableCollection<UsersDTO>(_users.getAll());
		}
	}
}
