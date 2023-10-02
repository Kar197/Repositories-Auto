using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
	public class UserRepositories:IUserRepository
	{
		private readonly AutoDbContext _context;
		public UserRepositories(AutoDbContext context)
		{
			_context = context;
		}
		public int Add(Auto auto)
		{
			_context.Add(auto);
			_context.SaveChanges();
		}
		public void Delete(int Id)
		{
			_context.Remove(_context.Find(Id));
		}

		public void GetAll()
		{
			_context.GetAll();
		}
		public User GetById(int Id)
		{
			return _context.Find(Id);
		}

		public void SaveChanges()
		{
			_context.SaveChanges();
		}

		void GetById(int Id)
		{
			throw new NotImplementedException();
		}
	}
}
