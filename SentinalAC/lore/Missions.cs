public static class Missions {
    public static string Assign(string playerId) {
        var missions = new[] {
            "Detect a simulated spinbot",
            "Review a flagged audit trail",
            "Design a lore tag for a new vector"
        };
        var mission = missions[new Random().Next(missions.Length)];
        LoreDatabase.AssignMission(playerId, mission);
        return mission;
    }

    public static void ShowCompleted(string playerId) {
        var completed = LoreDatabase.GetCompletedMissions(playerId);
        Console.WriteLine($"Missions completed by {playerId}: {string.Join(", ", completed)}");
    }
}
