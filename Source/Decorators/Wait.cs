namespace MBT {

    public class Wait : Decorator {

        protected float timeToWait;
        protected float currentTime;
        protected float timeStep;

        public Wait(BehaviorNode node, float time, float timeStep) : base(node) {
            this.timeToWait = time;
            this.timeStep = timeStep;
        }

        public override void Initialize(NodeData data) {
            base.Initialize(data);
            currentTime = 0;
        }

        public override BehaviorState Evaluate() {
            if (currentTime < timeToWait) {
                state = BehaviorState.Evaluating;
                currentTime += timeStep;
                return state;
            }

            state = node.Evaluate();
            return state;
        }

    }
}