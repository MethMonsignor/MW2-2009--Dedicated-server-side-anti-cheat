public class VectorWallhack {
    public void Evaluate(Player p) {
        if (!IsVisible(p.Target) && p.HitSuccess) {
            DetectionManager.Flag(p, "Ghost Targeting Detected", 3);
        }
    }
}
