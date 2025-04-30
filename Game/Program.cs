namespace Game
{
    class Program
    {
        static void Main()
        {
            Arsenal arsenal = new Arsenal();

            Weapon sword = arsenal.GetWeapon("Меч");
            Human hero = new Human("Герой", 100, 15, sword);
            Console.WriteLine("Создан герой: \n" + hero + "\n");

            Undead zombie = new Undead(80, 10, "Зомби");
            Console.WriteLine($"Создан {zombie.Name}:\n{zombie}\n");

            Console.WriteLine("Начало боя!");
            hero.Fight(zombie);
            Console.WriteLine();

            Console.WriteLine($"Состояние после боя:\n{hero.Name}: {hero}\n{zombie.Name}: {zombie}\n");
        }
    }
}

