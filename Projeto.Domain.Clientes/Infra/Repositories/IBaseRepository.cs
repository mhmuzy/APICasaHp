﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Clientes.Infra.Repositories
{
    public interface IBaseRepository<T>
        where T : class
    {

        void Insert(T obj);

        void Update(T obj);

        void Delete(T obj);

        List<T> FindAll();

        T FindById(int id);

    }
}
