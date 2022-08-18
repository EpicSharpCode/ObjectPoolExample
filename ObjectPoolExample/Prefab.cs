using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolExample
{
    internal class Prefab : GameObject
    {
        public Prefab(string _name, Vector3 _position) : base(_name, _position) { }
    }

}
