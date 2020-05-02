using CarRentalProject.ApplicationLogic.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.DataAccess
{
    public class BaseRepository<T> : iRepository<T>
    {
        public T Add(T itemToAdd)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T itemToDelete)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Update(T itemToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
