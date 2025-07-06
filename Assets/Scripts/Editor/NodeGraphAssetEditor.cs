using UnityEngine;
using UnityEditor;

namespace NodeGraph.Editor
{
    [CustomEditor(typeof(NodeGraphAsset))]
    public class NodeGraphAssetEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            if (GUILayout.Button("Open"))
            {
                NodeGraphEditorWindow.Open((NodeGraphAsset)target);
            }
        }
    }
}
