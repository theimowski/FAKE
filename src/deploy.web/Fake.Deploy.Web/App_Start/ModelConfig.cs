﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Raven.Client.Indexes;
using Raven.Database.Server;

namespace Fake.Deploy.Web
{
    public class ModelConfig
    {
        public static void Init()
        {
            NonAdminHttp.EnsureCanListenToWhenInNonAdminContext(8082);
            Fake.Deploy.Web.Model.Init();
        }

    }
}