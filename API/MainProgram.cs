public class MainProgram
{
    public static void Main(string[] args)
    {
        // إضافة لاعبين
        Player player1 = new Player("Player1", "STEAM_123456789");
        Player player2 = new Player("Player2", "STEAM_987654321");

        PlayerManager.AddPlayer(player1);
        PlayerManager.AddPlayer(player2);

        // تعيين أدوار
        PlayerManager.AssignRole("STEAM_123456789", RoleType.Admin);
        PlayerManager.AssignRole("STEAM_987654321", RoleType.VIP);

        // إضافة علامات
        PlayerManager.AddTag("STEAM_123456789", "مطور");
        PlayerManager.AddTag("STEAM_987654321", "مميز");

        // عرض معلومات اللاعبين
        PlayerManager.DisplayAllPlayers();

        // إزالة لاعب
        PlayerManager.RemovePlayer("STEAM_123456789");

        // عرض معلومات اللاعبين بعد الإزالة
        PlayerManager.DisplayAllPlayers();
    }
}