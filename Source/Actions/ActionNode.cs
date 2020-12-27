namespace MBT {

    public abstract class ActionNode : BehaviorNode {

        protected abstract BehaviorState ExecuteAction();

        public ActionNode() { }

        public override BehaviorState Evaluate() {
            return ExecuteAction();
        }

    }
}