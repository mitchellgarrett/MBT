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
    }

    protected override BehaviorState ExecuteAction() {
        text = data.Get<string>(key);
        Debug.Log(text);
        return BehaviorState.Success;
    }
}
