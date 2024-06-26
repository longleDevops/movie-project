using System;
namespace ApplicationCore.Contracts.Repository
{
	public interface IRepository<T> where T: class
	{
		T GetByID(int id);
		IEnumerable<T> GetAll();
		T Add(T entity);
		T Update(T entity);
		T Delete(T entity);
	}
}

