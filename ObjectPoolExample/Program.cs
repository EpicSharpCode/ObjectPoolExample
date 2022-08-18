using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolExample
{
    internal class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            var container = new GameObject("Container", Vector3.Zero);
            var prefab = new GameObject("Triangle", Vector3.Zero);
            var objectPool =
                new ObjectPool<GameObject>(prefab, 5, container, false);
            GameObject obj;

            Console.WriteLine("Default pool:\n");
            obj = objectPool.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPool.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPool.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }

            Console.WriteLine(objectPool.ToString());
            Console.WriteLine();

            obj = objectPool.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPool.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPool.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }

            Console.WriteLine(objectPool.ToString());


            Console.WriteLine("\n\nExpandable pool:\n");


            var prefab2 = new GameObject("Square", Vector3.Zero);
            var container2 = new GameObject("Container2", Vector3.Zero);
            var objectPoolExpandable =
                new ObjectPool<GameObject>(prefab2, 5, container2, true);
            obj = objectPoolExpandable.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPoolExpandable.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPoolExpandable.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPoolExpandable.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPoolExpandable.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            Console.WriteLine(objectPoolExpandable.ToString());


            obj = objectPoolExpandable.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPoolExpandable.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPoolExpandable.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPoolExpandable.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            obj = objectPoolExpandable.GetFreeElement();
            if (obj != null) { obj.SetPosition(new Vector3(random.Next(0, 5), 1, random.Next(0, 5))); }
            Console.WriteLine(objectPoolExpandable.ToString());

            Console.ReadLine();
        }
    }
}
