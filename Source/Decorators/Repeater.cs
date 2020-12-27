namespace MBT {

    public class Repeater : Decorator {

        protected int repetitions;
        protected int iteration;

        public Repeater(BehaviorNode node, int repetitions) : base(node) {
            this.repetitions = repetitions;
            iteration = 0;
        }

        public override BehaviorState Evaluate() {
            if (iteration >= repetitions) {
                state = BehaviorState.Failure;
                return state;
            }

            state = node.Evaluate();
            if (state != BehaviorState.Evaluating) iteration++;

            return state;
        }

    }
}