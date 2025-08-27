public class VectorAimbot {
    public void Evaluate(Player p) {
        if (p.AngularVelocity > 300 && p.Accuracy > 95) {
            DetectionManager.Flag(p, "Neural Targeting Implant", 2);
        }
    }
}
