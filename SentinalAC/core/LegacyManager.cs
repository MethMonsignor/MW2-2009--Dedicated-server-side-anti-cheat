public static class LegacyManager {
    public static void ExportConfig() {
        File.Copy("SentinelConfig.ini", $"Legacy/Config_{DateTime.UtcNow:yyyyMMdd}.ini");
    }

    public static void ReviewHistory(string playerId) {
        var history = AuditTrail.Query(playerId);
        Missions.ShowCompleted(playerId);
    }
}
