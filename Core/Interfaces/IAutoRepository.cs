using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
	public interface IAutoRepository
	{
		int Add(Auto auto);
		void Delete(int Id);
		Auto GetById(int Id);
		void GetAll();
		void SaveChanges();
	}
}
