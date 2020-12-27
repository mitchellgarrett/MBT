namespace MBT {

    public class Inverter : Decorator {

        public Inverter(BehaviorNode node) : base(node) { }

        public override BehaviorState Evaluate() {
            switch (node.Evaluate()) {
                case BehaviorState.Evaluating:
                    state = BehaviorState.Evaluating;
                    break;
                case BehaviorState.Success:
                    state = BehaviorState.Failure;
                    break;
                case BehaviorState.Failure:
                    state = BehaviorState.Success;
                    break;
            }

            return state;
        }

    }
}