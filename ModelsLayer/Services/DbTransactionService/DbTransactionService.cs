using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLayer.Services.DbTransactionService
{
    public class DbTransactionService : IDbTransactionService
    {
        public DbTransactionService() 
        {}
        public bool CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public void OpenTransaction()
        {
            throw new NotImplementedException();
        }

        public bool RollbackTransactrion()
        {
            throw new NotImplementedException();
        }
    }
}
