namespace MBT {

    public class RepeatUntilFail : Decorator {

        public RepeatUntilFail(BehaviorNode node) : base(node) { }

        public override BehaviorState Evaluate() {
            if (state == BehaviorState.Failure) return state;

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