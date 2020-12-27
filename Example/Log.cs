using MBT;
using UnityEngine;

public class Log : ActionNode {

    string key;
    string text;

    public Log() : this("log") { }

    public Log(string logKey) {
        this.key = logKey;
    }

    public override void Initialize(NodeData data) {
        base.Initialize(data);
        text = data.Get<string>(key);
    }

    protected override BehaviorState ExecuteAction() {
        return BehaviorState.Success;
    }
}