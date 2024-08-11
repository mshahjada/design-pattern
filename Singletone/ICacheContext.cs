using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public interface ICacheContext
    {
        bool GetConnectionStatus();
    }
}
