using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Game
{
    public class Weapon
    {
        public string Name { get; set; }

        private int _attackBuff;
        public int AttackBuff 
        { 
            get => _attackBuff;   
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Урон оружия не может быть меньше нуля");
                }
                else
                {
                    _attackBuff = value;
                }
            }
        }

        private float _attackSpeed;
        public float AttackSpeed 
        {
            get => _attackSpeed;
            

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Скорость атаки оружия не может быть меньше нуля");
                }
                else
                {
                    _attackSpeed = value;
                }
            }
        }

        public Weapon(string name, int atckBuff, float atckSpeed)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Название оружия не может быть пустым.");
            else
            {
                Name = name;
                AttackBuff = atckBuff;
                AttackSpeed = atckSpeed;
            }
               
        }

        public override string ToString()
        {
            return $"{Name} \nУрон: {AttackBuff}\nСкорость атаки: {AttackSpeed}";
        }
    }
}
