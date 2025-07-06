using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace NodeGraph.Editor
{
    public class NodeGraphEditorWindow : EditorWindow
    {
        public static void Open(NodeGraphAsset target)
        {
            NodeGraphEditorWindow[] windows = Resources.FindObjectsOfTypeAll<NodeGraphEditorWindow>();
            foreach (var w in windows)
            {
                if (w.m_currentGraph == target)
                {
                    w.Focus();
                    return;
                }
            }

            NodeGraphEditorWindow window = CreateWindow<NodeGraphEditorWindow>(typeof(NodeGraphEditorWindow), typeof(SceneView));
            window.titleContent = new GUIContent($"{target.name}", EditorGUIUtility.ObjectContent(null, typeof(NodeGraphAsset)).image);
            window.Load(target);
        }

        [SerializeField]
        private NodeGraphAsset m_currentGraph;

        [SerializeField]
        private SerializedObject m_serializedObject;

        [SerializeField]
        private NodeGraphView m_currentView;

        public NodeGraphAsset currentGraph => m_currentGraph;

        public void Load(NodeGraphAsset target)
        {
            m_currentGraph = target;
            DrawGraph();
        }

        private void DrawGraph()
        {
            m_serializedObject = new SerializedObject(m_currentGraph);
            m_currentView = new NodeGraphView();
            rootVisualElement.Add(m_currentView);

        }

    }
}
