﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManager.WebApp.Models
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);

        void Update(T entity);

        void Delete(int id);

        T GetById(int id);

        IList<T> GetAll();

    }
}
