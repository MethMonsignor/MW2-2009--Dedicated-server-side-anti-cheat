public static class RedemptionSystem {
    public static void Offer(string playerId) {
        var mission = Missions.Assign(playerId);
        LoreDatabase.AssignMission(playerId, mission);
    }

    public static bool CheckCompletion(string playerId, string missionId) {
        return LoreDatabase.CheckMissionCompletion(playerId, missionId);
    }
}
