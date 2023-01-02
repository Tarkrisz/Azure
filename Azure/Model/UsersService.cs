using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azure.Model
{
	public class UsersService
	{
		public tkservEntities _tk;
		public UsersService()
		{
			_tk = new tkservEntities();
		}

		public List<UsersDTO> getAll()
		{
			List<UsersDTO> names = new List<UsersDTO>();
			try
			{
				var query = from asd in _tk.Users
							select asd;
				foreach (var item in query)
				{
					names.Add(new UsersDTO { Id = item.ID, Name = item.Name });
				}
			}
			catch (Exception)
			{

				throw;
			}
			return names;
		}
	}
}
