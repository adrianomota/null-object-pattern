using System;

namespace ConsoleApp
{
    internal class PlayerCharacter
    {
        private readonly SpecialDefense _specialDefense;

        public PlayerCharacter(SpecialDefense specialDefense)
        {
            _specialDefense = specialDefense;
        }

        public string Name { get; private set; }

        public int Health { get; private set; } = 100;

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetHealth(int health)
        {
            Health = health;
        }

        public void Hit(int damage)
        {
            //int damageReduction = 0;

            //if (_specialDefense != null)
            //{
            //    damageReduction = _specialDefense.CalculateDamageReduction(damage);
            //}

            //int totalDamageToken = damage - damageReduction;

            int totalDamageToken = damage - _specialDefense.CalculateDamageReduction(damage);

            Health -= totalDamageToken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageToken} to {Health}.");
        }
    }
}