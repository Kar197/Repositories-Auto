using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
	public class AutoRepository : IAutoRepository
	{
		private readonly AutoDbContext _context;
		public AutoRepository(AutoDbContext context)
		{
			_context = context;
		}

		public int Add(Auto auto)
		{
			_context.Add(auto);
			_context.SaveChanges();
		}

		public int Add(Auto auto)
		{
			throw new NotImplementedException();
		}

		public void Delete(int Id)
		{
			_context.Remove(_context.Find(Id));
		}

		public void GetAll()
		{
			_context.GetAll();
		}

		public Auto GetById(int Id)
		{
			return _context.Find(Id);
		}

		public Auto GetById(int Id)
		{
			throw new NotImplementedException();
		}

		public void SaveChanges()
		{
			_context.SaveChanges();
		}
	}
}
