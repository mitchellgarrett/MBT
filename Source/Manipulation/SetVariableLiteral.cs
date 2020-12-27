namespace MBT {

    public class SetVariableLiteral : BehaviorNode {

        readonly string key;
        readonly object value;

        public SetVariableLiteral(string key, object value) {
            this.key = key;
            this.value = value;
        }

        public override void Initialize(NodeData data) {
            base.Initialize(data);
            data.Set(key, value);
        }

        public override BehaviorState Evaluate() {
            state = BehaviorState.Success;
            return state;
        }
    }

}