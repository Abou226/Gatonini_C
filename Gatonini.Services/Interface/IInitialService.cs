using Gatonini.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gatonini
{
    public interface IInitialService
    {
        Task<Secrets> Get(LogInModel token);
    }
}
