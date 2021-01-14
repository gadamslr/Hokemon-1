using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Hokemon hokemon1 = new Hokemon();
            Hokemon hokemon2 = new Hokemon();
        }
    }
    public class Hokemon
    {
        public Hokemon() //constuctor
        {
            void getName()
            {
                Console.WriteLine("Enter a name for your Hokemon");

                Name = Console.ReadLine();
            }
            void getDetails()
            {
                Console.WriteLine("Name: {0}\nHealth: {1}/{2}\nAttack: {3}\nDefense: {4}\nSpeed: {5}\n",name, health, maxHealth, attack, defense, speed);
            }
            int random_int_generator(int minValue, int maxValue)
            {
                Random rnd = new Random();
                int randomValue;
                randomValue = rnd.Next(minValue, maxValue);
                return randomValue;
            }
            getName();
            maxHealth = 100;
            health = maxHealth;
            //health = random_int_generator(10, maxHealth);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);
            getDetails();
        }
        private string name;
        private int health;
        private int attack;
        private int maxHealth;
        private int speed;
        private int defense;
        public string Name
        {
            get { return  name; }
            set { name = value;  }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }
    }
    


}
