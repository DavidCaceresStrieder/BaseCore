using Microsoft.EntityFrameworkCore;
using ModelsLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    using System.Reflection;

namespace ModelsLayer.EntityFramework
{
    public class EFGenericRepository<T, G>
        where T : BaseEntity
        where G : DbContext
    {

        protected virtual DbContext UnitOfWork { get; set; }
        protected virtual DbSet<T> itemDbSet { get; set; }


        public EFGenericRepository(DbContext context) {
            UnitOfWork = context;
            itemDbSet = UnitOfWork.Set<T>();
        }        

        public virtual T Save(T Item)
        {
            if (Item.ID == Guid.Empty)
            {
                Item.ID = Guid.NewGuid();
                this.itemDbSet.Add(Item);
                this.UnitOfWork.SaveChanges();
            }
            else
            {
                this.UnitOfWork.Entry(Item).State = EntityState.Modified;
                this.UnitOfWork.SaveChanges();                
            }
                
            return Item;
        }

        public virtual T Load(Guid ID)
        {
            return this.itemDbSet
                .Where(x=>x.ID == ID)
                .FirstOrDefault();
        }
    
        public virtual void Delete(Guid ID)
        {
            var itemToDelete = this.itemDbSet
                .Where(x => x.ID == ID)
                .SingleOrDefault();

            this.UnitOfWork.Attach(itemToDelete);
            this.UnitOfWork.Remove(itemToDelete);
            this.UnitOfWork.SaveChanges();
        }

        /// <summary>
        /// This Method return a non-trackeableQuery by default
        /// For a trackeable instance of the DbSet send the boolean in true
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<T> Query(bool trakeable = false)
        {
            return trakeable ? this.itemDbSet.AsTracking<T>() : this.itemDbSet.AsNoTracking<T>();
        }

    }
}
