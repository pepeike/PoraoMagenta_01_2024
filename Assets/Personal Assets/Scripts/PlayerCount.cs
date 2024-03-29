public static class PlayerCount {

    private static int playerCount = 0;

    public static void SetPlayerCount(int count) {
        playerCount = count;
    }

    public static int GetPlayerCount() {
        return playerCount; 
    }

}
