using UnityEngine;
using UnityEngine.UIElements;

namespace GraphViewPlayer
{
    [UxmlElement]
    [HideInInspector]
    public partial class CubeNode : BaseNode
    {
        private GameObject _Cube;

        public CubeNode()
        {
            Title = "Cube Node";
            _Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

            _Cube.transform.position = new Vector3(6, 2.5f, 0);
        }
    }
}