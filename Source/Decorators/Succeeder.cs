namespace MBT {

    public class Succeeder : Decorator {

        public Succeeder(BehaviorNode node) : base(node) { }

        public override BehaviorState Evaluate() {
            if (node.Evaluate() != BehaviorState.Evaluating) {
                state = BehaviorState.Success;
            }
            
            return state;
        }

    }
}