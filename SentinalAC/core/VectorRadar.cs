public class VectorRadar {
    public void Evaluate(Player p) {
        if (p.ReactToUnseenEnemies && !p.HasUAV) {
            DetectionManager.Flag(p, "Echo Mapping Breach", 3);
        }
    }
}
