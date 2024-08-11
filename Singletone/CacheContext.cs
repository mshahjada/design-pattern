using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public sealed class CacheContext: ICacheContext
    {
       
        private CacheContext()
        {
        }

        //private static CacheContext _context = new CacheContext();
        private static Lazy<CacheContext> _context = new Lazy<CacheContext>(() => new CacheContext());  
        public static CacheContext Instance => _context.Value;
        public bool GetConnectionStatus()
        {
            return _context.IsValueCreated;
        }
    }
}
