using UnityEngine;
using UnityEngine.UIElements;

namespace GraphViewPlayer
{
    [UxmlElement]
    [HideInInspector]
    public partial class SphereNode : BaseNode
    {
        private GameObject _Sphere;

        public SphereNode()
        {
            Title = "Sphere Node";
            _Sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            _Sphere.transform.position = new Vector3(5, 2.5f, 0);
        }
    }
}