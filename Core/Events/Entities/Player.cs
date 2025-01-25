using System;
using DZCP.Events.Entities;

namespace سست.Core.Event.Entities
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Role Role { get; set; }

        public Player(string name, int health, Role role)
        {
            Name = name;
            Health = health;
            Role = role;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} has been defeated!");
            }
        }
    }
}