﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringTest
{
    public interface IUserInfoDal
    {
        UserInfo UserInfo { get; set; }
        string Name { get; set; }

        string Show();
    }
}
