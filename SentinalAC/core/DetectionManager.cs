public class DetectionManager {
    public void Monitor(Player p) {
        new VectorWallhack().Evaluate(p);
        new VectorAimbot().Evaluate(p);
        new VectorSpinbot().Evaluate(p);
        new VectorRadar().Evaluate(p);
        new VectorBehavior().Evaluate(p);
    }

    public void Flag(Player p, string reason, int severity) {
        AuditTrail.Log(p.Id, reason, severity);
        OperativeFlags.Mark(p.Id, reason);
        FactionLogic.InterpretFlag(p.Id, reason, severity);
    }
}
