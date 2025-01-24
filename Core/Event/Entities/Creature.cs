using System;

namespace سست.Core.Event.Entities
{
    public class Creature
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Creature(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public void Attack(Player player)
        {
            player.TakeDamage(Damage);
            Console.WriteLine($"{Name} attacked {player.Name} for {Damage} damage!");
        }
    }
}