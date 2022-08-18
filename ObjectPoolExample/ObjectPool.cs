using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolExample
{
    internal class ObjectPool<T> where T : GameObject
    {
        T prefab;
        bool autoExpand = false;
        List<T> pool;

        GameObject container = null;

        public ObjectPool(T _prefab, int _count, bool _autoExpand = false)
        {
            prefab = _prefab;
            autoExpand = _autoExpand;
            CreatePool(_count);
        }
        public ObjectPool(T _prefab, int _count, GameObject _container, bool _autoExpand = false)
        {
            prefab = _prefab;
            autoExpand = _autoExpand;
            container = _container;
            CreatePool(_count);
        }

        public void CreatePool(int _count)
        {
            pool = new List<T>();

            for (int i = 0; i < _count; i++)
            {
                CreateObject(false);
            }
        }
        private T CreateObject(bool _activeSelf)
        {
            var obj = (T)new GameObject(prefab);
            obj.SetActive(_activeSelf);
            obj.SetParent(container);
            pool.Add(obj);
            return obj;
        }

        public T GetFreeElement()
        {
            var gameObject = pool.Find(x => x.activeSelf == false);
            if(gameObject != null) 
            { 
                gameObject.SetActive(true);
                return gameObject; 
            }
            
            if(autoExpand)
            {
                return CreateObject(true);
            }

            Console.WriteLine($"[ERROR] - Pool don't have any other free elements of {typeof(T).Name}");
            return null;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Active Elements:");
            var activeObjects = pool.FindAll(x => x.activeSelf == true);
            foreach (T obj in activeObjects)
            {
                stringBuilder.AppendLine(obj.ToString());
            }
            stringBuilder.AppendLine($"Count of active objects: {activeObjects.Count}");
            stringBuilder.AppendLine($"Total count objects: {pool.Count}");
            return stringBuilder.ToString();
        }
    }
}
