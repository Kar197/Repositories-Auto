using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
	public interface IUserRepository
	{
		void Add(/*User user*/);
		void Delete(int Id);
		User GetById(int Id);
		void GetAll();
		void SaveChanges();
	}
}