using UnityEngine.UIElements;
using UnityEngine;

namespace GraphWindow
{
    [UxmlElement]
    partial class GraphBase : VisualElement
    {
        #region Attributes
        [UxmlAttribute]
        public string myString { get; set; } = "default_value";

        [UxmlAttribute]
        public int myInt { get; set; } = 2;
        #endregion

        #region Constructor
        public GraphBase()
        {
            styleSheets.Add(Resources.Load<StyleSheet>("GraphBaseStyle"));
            AddToClassList("graph-view");
        }
        #endregion
    }
}