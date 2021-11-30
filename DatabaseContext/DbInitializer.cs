﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Auth0MVCApp.DatabaseContext
{
    public class DbInitializer
    {
        public static void Initialize(LmcTeamDatabaseContext context)
    {
            context.Database.EnsureCreated();
    }
    }
}
