using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPoolExample
{
    internal class GameObject
    {
        public string name = "";
        public Vector3 position = Vector3.Zero;
        public GameObject parent { get; private set; } = null;
        public bool activeSelf { get; private set; } = false;

        public GameObject(string _name, Vector3 _position, GameObject _parent = null, bool _activeSelf = false)
        {
            name = _name;
            position = _position;
            parent = _parent;
            activeSelf = _activeSelf;
        }
        public GameObject(GameObject _gameObject)
        {
            name = _gameObject.name;
            position = _gameObject.position;
            parent = _gameObject.parent;
            activeSelf = _gameObject.activeSelf;
        }
        public void SetActive(bool state) => activeSelf = state;
        public void SetParent(GameObject newParent) => parent = newParent;
        public void SetPosition(Vector3 newPos) => position = newPos;

        public override string ToString()
        {
            string parentName = parent != null ? parent.name : "none";
            return $"GameObject {name} in pos {position}, child of {parentName}";
        }
    }
}
