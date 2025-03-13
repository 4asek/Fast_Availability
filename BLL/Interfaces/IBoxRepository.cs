using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface IBoxRepository
    {
        public ICollection<Box> GetAll();
        public Box GetById (Guid id);
        public void CreateItem(Box box);
        public void RemoveById(Guid id);
        public void RemoveAll();
        public void Update(Box box); 

    }
}
