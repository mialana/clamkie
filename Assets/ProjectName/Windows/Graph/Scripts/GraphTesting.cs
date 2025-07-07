using UnityEngine;
using UnityEngine.UIElements;

namespace GraphViewPlayer
{
    [UxmlElement]
    public partial class GraphTesting : GraphView
    {
        public GraphTesting() {}

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