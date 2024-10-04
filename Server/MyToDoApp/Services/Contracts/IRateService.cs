using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Services.Contracts
{
    public interface IRateService
    {
        Task<int> GetRate();
    }
}
