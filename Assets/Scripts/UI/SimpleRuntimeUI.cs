using UnityEngine;
using UnityEngine.UIElements;
using GraphViewPlayer;

public class SimpleRuntimeUI : MonoBehaviour
{
    private Button _button;
    private Toggle _toggle;

    private GraphWindow _graph;
    private BaseNode _node;

    private int _clickCount;

    private void Awake()
    {
        // The UXML is already instantiated by the UIDocument component
        var uiDocument = GetComponent<UIDocument>();

        _graph = uiDocument.rootVisualElement.Q("GraphTesting") as GraphWindow;
        _button = uiDocument.rootVisualElement.Q("button") as Button;
        _toggle = uiDocument.rootVisualElement.Q("toggle") as Toggle;

        _button.RegisterCallback<ClickEvent>(PrintClickMessage);

        var _inputFields = uiDocument.rootVisualElement.Q("input-message");
        _inputFields.RegisterCallback<ChangeEvent<string>>(InputMessage);
    }

    //Add logic that interacts with the UI controls in the `OnEnable` methods
    private void OnEnable()
    {

        _node = new BaseNode();
        _node.style.left = 100;
        _node.style.top = 100;

        _graph.AddElement(_node);
    }

    private void OnDisable()
    {
        _button.UnregisterCallback<ClickEvent>(PrintClickMessage);
    }

    private void PrintClickMessage(ClickEvent evt)
    {
        ++_clickCount;

        Debug.Log($"{"button"} was clicked!" +
                (_toggle.value ? " Count: " + _clickCount : ""));
    }

    public static void InputMessage(ChangeEvent<string> evt)
    {
        Debug.Log($"{evt.newValue} -> {evt.target}");
    }
}
