public static class LoreDiagnostics {
    public static void OfferRedemption(string playerId) {
        var mission = Missions.Assign(playerId);
        LoreDatabase.AssignMission(playerId, mission);
        Console.WriteLine($"Redemption mission for {playerId}: {mission}");
    }

    public static bool ValidateRedemption(string playerId, string missionId) {
        return LoreDatabase.CheckMissionCompletion(playerId, missionId);
    }

    public static void RunSelfDiagnostic(string playerId) {
        var report = new {
            playerId,
            timestamp = DateTime.UtcNow,
            integrityScore = CalculateIntegrity(playerId),
            recentFlags = AuditTrail.Query(playerId),
            faction = FactionLogic.GetFaction(playerId)
        };

        Console.WriteLine(JsonConvert.SerializeObject(report, Formatting.Indented));
    }

    private static int CalculateIntegrity(string playerId) {
        var flags = AuditTrail.Query(playerId);
        return 100 - (flags.Count * 10); // Simple score: 100 minus 10 per flag
    }
}
