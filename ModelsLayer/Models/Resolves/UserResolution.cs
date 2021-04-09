using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ModelsLayer.DAL;
using ModelsLayer.EntityFramework;
using ModelsLayer.Models.Promises;

namespace ModelsLayer.Models.Resolves
{
    public class UserResolution : EFGenericRepository<User, WorkContext>, IUserDB
    {
        public UserResolution(WorkContext GameContext) : base(GameContext)
        {            
        }
    }
}
