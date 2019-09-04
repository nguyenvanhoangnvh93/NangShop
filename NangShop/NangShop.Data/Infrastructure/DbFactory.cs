﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NangShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private NangShopDBContext dbContext;

        public NangShopDBContext Init()
        {
            return dbContext ?? (dbContext = new NangShopDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
