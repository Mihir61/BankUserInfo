﻿using BankUserInfo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUserInfo.Repo
{

    public interface IRepository<T> where T : Entity
    {
        void Add(T item);

        IEnumerable<T> GetAll();

        T GetById(int id);

        void DeleteById(int id);

        void DeleteByItem(T item);
        
    }
}

