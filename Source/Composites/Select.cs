using System.Collections.Generic;

namespace MBT {

    public class Selector : Composite {

        public Selector(params BehaviorNode[] nodes) : base(nodes) { }

        public Selector(List<BehaviorNode> nodes) : base(nodes) { }

        public override void Initialize(NodeData data) {
            base.Initialize(data);
            foreach (BehaviorNode node in nodes) {
                node.Initialize(data);
            }
        }

        public override BehaviorState Evaluate() {
            foreach (BehaviorNode node in nodes) {
                switch (node.Evaluate()) {
                    case BehaviorState.Evaluating:
                        state = BehaviorState.Evaluating;
                        return state;
                    case BehaviorState.Success:
                        state = BehaviorState.Success;
                        return state;
                    case BehaviorState.Failure:
                        continue;
                }
            }

            state = BehaviorState.Failure;
            return state;
        }

    }
}