﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class BasicAuthorizeAttribute: AuthorizeAttribute
    {
        public BasicAuthorizeAttribute()
        {
            Policy = "BasicAuthentication";

        }
    }
}
