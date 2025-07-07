using UnityEngine;
using UnityEngine.UIElements;

namespace GraphViewPlayer
{
    [UxmlElement]
    public partial class GraphWindow : GraphView
    {
        public GraphToolBar _toolbar;

        public GraphWindow()
        {
            RegisterCallback<AttachToPanelEvent>((evt) =>
            {
                style.width = Length.Percent(50);
                style.height = Length.Percent(100);

                _toolbar = new GraphToolBar();

                AddDefaultButtons();

                hierarchy.Add(_toolbar); // add as sibling element
            });
        }

        private void AddDefaultButtons()
        {
            #region CubeButton
            Button _cubeButton = new Button() { name = "cubeButton", text = "Cube Button" };

            _cubeButton.RegisterCallback<ClickEvent>((evt) =>
            {
                var node = new CubeNode();
                node.style.top = 50;
                node.style.left = 10;
                AddElement(node);
            });

            _toolbar.AddButton(0, _cubeButton);
            #endregion

            #region SphereButton
            Button _sphereButton = new Button() { name = "sphereButton", text = "Sphere Button" };

            _sphereButton.RegisterCallback<ClickEvent>((evt) =>
            {
                var node = new SphereNode();
                node.style.top = 150;
                node.style.left = 100;
                AddElement(node);
            });

            _toolbar.AddButton(1, _sphereButton);
            #endregion

        }

        protected override void ExecuteCopy() { Debug.Log("OnCopy"); }

        protected override void ExecuteCut() { Debug.Log("OnCut"); }

        protected override void ExecutePaste() { Debug.Log("OnPaste"); }

        protected override void ExecuteDuplicate() { Debug.Log("OnDuplicate"); }

        protected override void ExecuteDelete() { Debug.Log("OnDelete"); }

        protected override void ExecuteUndo() { Debug.Log("OnUndo"); }

        protected override void ExecuteRedo() { Debug.Log("OnRedo"); }

        protected override void ExecuteEdgeCreate(BaseEdge edge)
        {
            Debug.Log("Edge created");
            AddElement(edge);
        }

        protected override void ExecuteEdgeDelete(BaseEdge edge)
        {
            Debug.Log("Edge deleted");
            RemoveElement(edge);
        }

        //protected override void OnNodeMoved(BaseNode element) { }

        protected override void OnViewportChanged() { }
    }

}