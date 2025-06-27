using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics5
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        IEnumerable<T> GetAll();
    }

    public class Repository<T> : IRepository<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item) => _items.Add(item);

        public void Remove(T item) => _items.Remove(item);

        public IEnumerable<T> GetAll() => _items;
    }
}
