public static class FactionLogic {
    public static string GetFaction(string playerId) {
        return LoreDatabase.QueryFaction(playerId);
    }

    public static void InterpretFlag(string playerId, string reason, int severity) {
        var faction = GetFaction(playerId);
        switch (faction) {
            case "Archivists": RedemptionSystem.Offer(playerId); break;
            case "Enforcers": AdminActions.TempBan(playerId, TimeSpan.FromHours(24)); break;
            case "Watchers": AuditTrail.Log(playerId, reason + " (Behavioral)", severity); break;
        }
    }
}
