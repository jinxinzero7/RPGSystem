using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Models
{
    internal class Entity : IFigthable
    {
        private int _healthPoints;
        public int HealthPoints
        {
            get => _healthPoints;
            
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Здоровье не может быть меньше нуля");
                }
                else
                {
                    _healthPoints = value;
                }
            }
        }

        private int _attackDamage;
        public int AttackDamage
        {
            get => _attackDamage;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Атака не может быть меньше нуля");
                }
                else
                {
                    _attackDamage = value;
                }
            }
        }

        public Entity(int hp, int atck) 
        {
            AttackDamage = atck;
            HealthPoints = hp;
        }

        public void Fight(Entity entity1)
        {
            if (entity1 != null)
            {
                try
                {
                    int entityTempHealth = entity1.HealthPoints;
                    int selfTempHealth = HealthPoints;

                    while (HealthPoints > 0 && entity1.HealthPoints > 0)
                    {
                        entityTempHealth -= AttackDamage;
                        if (entityTempHealth > 0)
                        {
                            selfTempHealth -= entity1.AttackDamage;
                        }
                        if (selfTempHealth <= 0)
                        {
                            selfTempHealth = 0;
                            HealthPoints = selfTempHealth;
                        }
                        if (entityTempHealth <= 0)
                        {
                            entityTempHealth = 0;
                            entity1.HealthPoints = entityTempHealth;
                        }
                    }
                    if (HealthPoints < 0 && entity1.HealthPoints < 0)
                        Console.WriteLine("Ничья");

                    else if (HealthPoints < 0)
                        Console.WriteLine("Вы проиграли");
                    else if (entity1.HealthPoints < 0)
                        Console.WriteLine("Вы выиграли");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Исключение: {ex.Message}");
                }
            }
        }

        public override string ToString() 
        {
            return $"Здоровье: {HealthPoints}, Атака: {AttackDamage}.";
        }

    }
}
