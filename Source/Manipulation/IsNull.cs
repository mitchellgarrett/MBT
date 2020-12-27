namespace MBT {

    public class IsNull : BehaviorNode {

        string key;

        public IsNull(string key) {
            this.key = key;
        }

        public override BehaviorState Evaluate() {
            if (data.Get<object>(key) == null) {
                state = BehaviorState.Success;
            } else {
                state = BehaviorState.Failure;
            }
            return state;
        }
    }

}