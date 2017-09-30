using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Core.Cache
{
    public interface ICacheManager
    {
        void Set<T>(string key, T value);

        T Get<T>(string key);

    }
}
