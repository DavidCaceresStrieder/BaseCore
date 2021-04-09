using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLayer.Services.DbTransactionService
{
    public interface IDbTransactionService
    {
        bool RollbackTransactrion();
        bool CommitTransaction();
        void OpenTransaction();

    }
}
