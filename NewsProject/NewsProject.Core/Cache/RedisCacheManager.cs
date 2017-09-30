using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace NewsProject.Core.Cache
{
    public class RedisCacheManager : ICacheManager
    {
        #region ICacheManager Members

        private ConnectionMultiplexer _redis;

        public RedisCacheManager()
        {
            _redis = ConnectionMultiplexer.Connect("localhost");
        }
        public void Set<T>(string key, T value)
        {
            IDatabase db = _redis.GetDatabase();
            
            db.StringSet(key, Newtonsoft.Json.JsonConvert.SerializeObject(value));
        }

        public T Get<T>(string key)
        {
            IDatabase db = _redis.GetDatabase();
            string value = db.StringGet(key);
            if (string.IsNullOrEmpty(value))
                return default(T);
            return  Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value);
        }


    
        #endregion

    }
}
