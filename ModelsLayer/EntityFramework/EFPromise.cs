using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelsLayer.EntityFramework
{
    public interface EFPromise<T>
    {
        T Save(T item);

        T Load(Guid ID);

        void Delete(Guid ID);

        IQueryable<T> Query(bool trakeable = false);
    }
}
