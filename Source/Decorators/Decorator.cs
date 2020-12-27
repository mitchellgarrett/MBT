namespace MBT {

    public abstract class Decorator : BehaviorNode {

        protected BehaviorNode node;

        public Decorator(BehaviorNode node) {
            this.node = node;
        }

        public override void Initialize(NodeData data) {
            base.Initialize(data);
            node.Initialize(this.data);
        }

    }
}
