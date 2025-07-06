using UnityEngine;
using UnityEngine.UIElements;

using GraphWindow;

public class GraphAssetBehavior : MonoBehaviour
{
    private GraphBase _graph;

    private void OnEnable()
    {
        // The UXML is already instantiated by the UIDocument component
        var uiDocument = GetComponent<UIDocument>();

        _graph = uiDocument.rootVisualElement.Q("GraphBase") as GraphBase;

    }

    private void OnDisable()
    {
    }
}
