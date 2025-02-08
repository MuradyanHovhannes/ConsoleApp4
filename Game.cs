using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class AnimalGame
    {
        private List<Animal> animals = new List<Animal> { new Dog(), new Cat(), new Cow() };

        public void Play()
        {
            Console.WriteLine("🎮 bari galust kendanun gushakir xaxin");
            Console.WriteLine("yntrir kentanun! 1- shun, 2-katu, 3-kov:");

            string choice = Console.ReadLine();
            Animal selectedAnimal = null;

            switch (choice)
            {
                case "1":
                    selectedAnimal = new Dog();
                    break;

                case "2":
                    selectedAnimal = new Cat();
                    break;
                case "3":
                    selectedAnimal = new Cow();
                    break;
                default:
                    Console.WriteLine("❌ sxal yntrutyun yntreq 1, 2, 3, !");
                    return;
            }

            if (selectedAnimal != null)
            {
                Console.WriteLine($"duq yntreciq {selectedAnimal.Name} - ev nra dzayne");
            }

            Console.WriteLine($"duq yntreciq {selectedAnimal.Name} - ev nra dzayne");
            selectedAnimal.MakeSound();


        }
    }
}
