using System;
using System.Collections.Generic;

public static class PlayerManager
{
    private static Dictionary<string, Player> players = new Dictionary<string, Player>();

    public static void AddPlayer(Player player)
    {
        if (!players.ContainsKey(player.SteamID))
        {
            players[player.SteamID] = player;
            Console.WriteLine($"تمت إضافة اللاعب {player.Name} إلى النظام.");
        }
    }

    public static void RemovePlayer(string steamID)
    {
        if (players.ContainsKey(steamID))
        {
            Console.WriteLine($"تمت إزالة اللاعب {players[steamID].Name} من النظام.");
            players.Remove(steamID);
        }
    }

    public static Player GetPlayer(string steamID)
    {
        if (players.ContainsKey(steamID))
        {
            return players[steamID];
        }
        return null;
    }

    public static void AssignRole(string steamID, RoleType role)
    {
        if (players.ContainsKey(steamID))
        {
            players[steamID].AssignRole(role);
        }
    }

    public static void AddTag(string steamID, string tag)
    {
        if (players.ContainsKey(steamID))
        {
            players[steamID].AddTag(tag);
        }
    }

    public static void RemoveTag(string steamID, string tag)
    {
        if (players.ContainsKey(steamID))
        {
            players[steamID].RemoveTag(tag);
        }
    }

    public static void DisplayAllPlayers()
    {
        foreach (var player in players.Values)
        {
            player.DisplayInfo();
        }
    }

    public static void Initialize()
    {
        throw new NotImplementedException();
    }
}