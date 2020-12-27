public enum BehaviorState { Evaluating, Success, Failure };

namespace MBT {

    public abstract class BehaviorNode {

        public BehaviorState state { get; protected set; }
        protected NodeData data;

        public virtual void Initialize(NodeData data) {
            this.data = data;
            state = BehaviorState.Evaluating;
        }

        public abstract BehaviorState Evaluate();
    }
}