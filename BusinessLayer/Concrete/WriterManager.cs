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
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return
            _writerDal.GetListAll(x => x.WriterID == id);
            
        }

        public void TAdd(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetbyID(id);
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }

        public void WriterAdd(Writer writer)
        {
            throw new NotImplementedException();
        }
    }
}
