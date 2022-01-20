using IdentityServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Services
{
  public  interface ICoffeeShopService
    {
        Task<List<CoffeeShopModel>> List();
    }
}
