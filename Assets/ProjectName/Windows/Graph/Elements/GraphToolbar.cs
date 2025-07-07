using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace GraphViewPlayer
{
    [UxmlElement]
    [HideInInspector]
    public partial class GraphToolBar : VisualElement
    {
        private static StyleSheet s_DefaultStyle;

        private readonly Dictionary<int, Button> m_Buttons;

        public GraphToolBar()
        {
            styleSheets.Add(DefaultStyle);
            AddToClassList("graph-toolbar");

            m_Buttons = new();
        }

        public void AddButton(int position, Button b)
        {
            b.styleSheets.Add(DefaultStyle);
            b.AddToClassList("graph-toolbar-button");
            hierarchy.Add(b);

            m_Buttons.Add(position, b);
        }

        private static StyleSheet DefaultStyle
        {
            get
            {
                if (s_DefaultStyle == null)
                {
                    s_DefaultStyle = Resources.Load<StyleSheet>("GraphToolbarStyle");
                }
                return s_DefaultStyle;
            }
        }
    }
}