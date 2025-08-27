public class VectorBehavior {
    public void Evaluate(Player p) {
        if (p.ReactionTime < 100 && p.TargetWasUnseen) {
            DetectionManager.Flag(p, "Synthetic Reflex Breach", 2);
        }

        if (p.Flags.ContainsMultipleVectors()) {
            DetectionManager.Flag(p, "Multi-System Compromise", 4);
        }
    }
}
