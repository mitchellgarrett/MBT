using System.Collections.Generic;

namespace MBT {

    public class Sequence : Composite {

        int index;
        bool visited;

        public Sequence(params BehaviorNode[] nodes) : base(nodes) { }

        public Sequence(List<BehaviorNode> nodes) : base(nodes) { }

        public override void Initialize(NodeData data) {
            base.Initialize(data);
            index = 0;
            visited = false;
        }

        public override BehaviorState Evaluate() {
            if (state != BehaviorState.Evaluating) return state;

            if (!visited) {
                nodes[index].Initialize(data);
                visited = true;
            }

            switch (nodes[index].Evaluate()) {
                case BehaviorState.Evaluating:
                    state = BehaviorState.Evaluating;
                    break;
                case BehaviorState.Success:
                    index++;
                    visited = false;
                    if (index >= nodes.Count) state = BehaviorState.Success;
                    break;
                case BehaviorState.Failure:
                    state = BehaviorState.Failure;
                    break;
            }

            return state;
        }

    }
}