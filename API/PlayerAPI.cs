using System;
using System.Collections.Generic;

public class Player
{
    public string Name { get; set; }
    public string SteamID { get; set; }
    public RoleType Role { get; set; }
    public List<string> Tags { get; set; } = new List<string>();

    public Player(string name, string steamID)
    {
        Name = name;
        SteamID = steamID;
        Role = RoleType.None; // الدور الافتراضي
    }

    public void AssignRole(RoleType role)
    {
        Role = role;
        Console.WriteLine($"تم تعيين الدور {role} للاعب {Name}.");
    }

    public void AddTag(string tag)
    {
        if (!Tags.Contains(tag))
        {
            Tags.Add(tag);
            Console.WriteLine($"تمت إضافة العلامة {tag} للاعب {Name}.");
        }
    }

    public void RemoveTag(string tag)
    {
        if (Tags.Contains(tag))
        {
            Tags.Remove(tag);
            Console.WriteLine($"تمت إزالة العلامة {tag} من اللاعب {Name}.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"اللاعب: {Name} (SteamID: {SteamID})");
        Console.WriteLine($"الدور: {Role}");
        Console.WriteLine("العلامات: " + string.Join(", ", Tags));
    }

    public void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }
}

public enum RoleType
{
    None,
    Admin,
    Moderator,
    VIP,
    Guest
}