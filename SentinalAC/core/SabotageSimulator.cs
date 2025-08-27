public class SabotageSimulator {
    public void Simulate(string vector) {
        switch (vector) {
            case "Spinbot": SimulateSpinbot(); break;
            case "Wallhack": SimulateWallhack(); break;
        }
    }

    private void SimulateSpinbot() {
        var syntheticPlayer = new Player {
            YawDelta = 1080,
            PitchDelta = 0,
            Accuracy = 100
        };
        DetectionManager.Monitor(syntheticPlayer);
    }
}
