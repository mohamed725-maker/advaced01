namespace advanced01
{
    public class Cashe<TKey, TValue>
    {
        private Dictionary<TKey, (TValue Value, DateTime Expiry)> items  = new Dictionary<TKey, (TValue, DateTime)>();
        public void Add(TKey key, TValue value, int seconds)
        {
            items[key] = (value, DateTime.UtcNow.AddSeconds(seconds));
        }

        
        public TValue Get(TKey key)
        {
            if (Contains(key))
            {
                return items[key].Value;
            }

            return default(TValue)!;
        }

        
        public bool Remove(TKey key)
        {
            return items.Remove(key);
        }

        public bool Contains(TKey key)
        {
            if (!items.ContainsKey(key))
            {
                return false;
            }

            if (DateTime.UtcNow >= items[key].Expiry)
            {
                items.Remove(key);
                return false;
            }

            return true;

        }   }
    }
