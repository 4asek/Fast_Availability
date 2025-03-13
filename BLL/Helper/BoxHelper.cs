using BLL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace BLL.Helper
{
    public class BoxHelper : IBoxRepository
    {
         private readonly ApplicationDbContext _dbcontext;
         public BoxHelper(ApplicationDbContext _dbcontext) 
         {
            this._dbcontext = _dbcontext;
         }

        public async void CreateItem(Box box)
        {
            await _dbcontext.AddAsync(box);
                  _dbcontext.SaveChanges();
        }

        public ICollection<Box> GetAll()
        {
            return _dbcontext.Boxes.ToList();
        }

        public Box GetById(Guid id)
        {
           Box ZminaBox = _dbcontext.Boxes.Find(id);
            if (ZminaBox == null)
            {
                throw new Exception("Biba ne Find");
            }
           return ZminaBox;
        }

        public void RemoveAll()
        {
            _dbcontext.Boxes.RemoveRange(_dbcontext.Boxes);
            _dbcontext.SaveChanges();
        }

        public async void RemoveById(Guid id)
        {
            Box RemoveBox = GetById(id);
            _dbcontext.Boxes.Remove(RemoveBox);
            _dbcontext.SaveChanges();
        }

        public void Update(Box box)
        {
            _dbcontext.Boxes.Update(box);
            _dbcontext.SaveChanges();
        }
    }
}
