using DAL.Abstract;
using DAL.Repositories;
using EntityKatmani.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EfWriterRepository: GenericRepository<Writer>, IWriterDal
    {
    }
}
