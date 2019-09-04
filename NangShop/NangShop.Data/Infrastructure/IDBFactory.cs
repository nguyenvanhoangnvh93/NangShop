using System;

namespace NangShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NangShopDBContext Init();
    }
}