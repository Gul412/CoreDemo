using BusinessLayer.Abstract;
using DAL.Abstract;
using DAL.EntityFramework;
using EntityKatmani.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
    {
        IWriterDal _writerdal;
		private EfWriterRepository efWriterRepository;

		public WriterManager(IWriterDal writerdal)
		{
			_writerdal = writerdal;
		}

		public WriterManager(EfWriterRepository efWriterRepository)
		{
			this.efWriterRepository = efWriterRepository;
		}

		public Writer GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Writer> GetList()
		{
			throw new NotImplementedException();
		}

		public Writer TGetByFilter(Expression<Func<Writer, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void WriterAdd(Writer writer)
		{
			throw new NotImplementedException();
		}

		public void WriterDelete(Writer writer)
		{
			throw new NotImplementedException();
		}

		public void WriterUpdate(Writer writer)
		{
			throw new NotImplementedException();
		}
	}
}
