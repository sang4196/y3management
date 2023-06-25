using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y3
{
    public class Singleton<T> where T : class, new()
    {
        protected static T _instance;
        protected static object _lock = new object();

        public static T Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new T();
                    }
                    return _instance;
                }
            }
        }

        public virtual void Clear()
        {
            _instance = null;
            _instance = new T();
        }
    }
}
