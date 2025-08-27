public class VectorSpinbot {
    public void Evaluate(Player p) {
        if (p.YawDelta > 720 && p.PitchDelta == 0) {
            DetectionManager.Flag(p, "Gyro Destabilizer Signature", 3);
        }
    }
}
