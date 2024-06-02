﻿using Bet.Common.Entities.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bet.Data.Interfaces
{
    public interface IUserData: IBaseData<User>
    {
        User Login(string userName, string passwordMd5);

    }
}
