namespace MBT {

    public class NodeDataManager : Decorator {

        NodeData prototype;

        public NodeDataManager(BehaviorNode node) : base(node) { }

        public NodeDataManager(BehaviorNode node, NodeData prototype) : base(node) {
            this.prototype = prototype;
        }

        public override void Initialize(NodeData data) {
            if (prototype != null) {
                this.data = new NodeData(data, prototype);
            } else {
                this.data = new NodeData(data);
            }

            base.Initialize(this.data);
        }

        public override BehaviorState Evaluate() {
            return node.Evaluate();
        }
        
    }

}