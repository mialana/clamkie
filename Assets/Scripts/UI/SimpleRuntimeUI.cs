using UnityEngine;
using UnityEngine.UIElements;

using GraphViewPlayer;

public class SimpleRuntimeUI : MonoBehaviour
{
    private GraphTesting _graph;
    private BaseNode _node;

    private void OnEnable()
    {
        // The UXML is already instantiated by the UIDocument component
        var uiDocument = GetComponent<UIDocument>();

        _graph = uiDocument.rootVisualElement.Q("GraphTesting") as GraphTesting;

        _node = new BaseNode { Title = "New Logic Node" };
        _node.style.left = 5;
        _node.style.top = 5;

        _graph.AddElement(_node);

    }

    private void OnDisable()
    {
    }
}