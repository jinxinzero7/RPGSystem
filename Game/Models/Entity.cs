using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public abstract class Entity : IFightable
    {
        private int _healthPoints;
        public int HealthPoints
        {
            get => _healthPoints;
            // тернарный оператор для сеттера здоровья
            set => _healthPoints = value < 0 ? 0 : value;
        }

        private int _attackDamage;
        public int AttackDamage
        {
            get => _attackDamage;
            // тернарный оператор для сеттера атаки
            set => _attackDamage = value < 0 ? 0 : value;
        }

        // конструктор entity
        public Entity(int hp, int atck) 
        {
            AttackDamage = atck;
            HealthPoints = hp;
        }

        // метод описывающий сражение между двумя классами наследующими интерфейс IFightable
        public void Fight(IFightable target)
        {
            // проверка на null
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            // само сражение
            while (HealthPoints > 0 && target.HealthPoints > 0)
            {
                target.HealthPoints -= AttackDamage;
                if (target.HealthPoints > 0)
                    HealthPoints -= target.AttackDamage;
            }

            // проверка результатов сражения
            if (HealthPoints <= 0 && target.HealthPoints <= 0)
                Console.WriteLine("Ничья");
            else if (HealthPoints <= 0)
                Console.WriteLine("Вы проиграли");
            else
                Console.WriteLine("Вы выиграли");
        }

        public override string ToString() 
        {
            return $"Здоровье: {HealthPoints}, Атака: {AttackDamage}";
        }

    }
}
