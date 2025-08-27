public static class OperativeFlags {
    public static void Mark(string playerId, string reason) {
        LoreDatabase.AddTag(playerId, $"Rogue Operative: {reason}");
    }

    public static string GetLoreStatus(string playerId) {
        return LoreDatabase.QueryTags(playerId);
    }
}
