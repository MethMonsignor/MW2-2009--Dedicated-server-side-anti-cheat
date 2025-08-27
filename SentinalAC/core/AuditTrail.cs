public static class AuditTrail {
    public static void Log(string playerId, string reason, int severity) {
        var entry = new {
            playerId,
            timestamp = DateTime.UtcNow,
            vector = reason,
            severity,
            replayLink = $"sentinel://replay/{GenerateReplayId()}",
            metadata = new {
                map = GameState.CurrentMap,
                matchId = GameState.MatchId,
                faction = FactionLogic.GetFaction(playerId)
            }
        };
        File.AppendAllText("Logs/AuditTrail.json", JsonConvert.SerializeObject(entry));
    }

    private static int GenerateReplayId() => new Random().Next(1000, 9999);
}
