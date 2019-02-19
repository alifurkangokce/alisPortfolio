using Ali.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Service
{
  public  interface ICategoryService
    {
        void Insert(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
        void Delete(Guid id);
        Category Find(Guid id);
        IEnumerable<Category> GetAll();
        IEnumerable<Category> GetAllByName(string name);


    }
}
