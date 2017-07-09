using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
            var listOfAnimals = new List<Animal>();
            var listOfFood = new List<Food>();
            var counter = 1;

            while (input[0] != "End")
            {
                if (counter % 2 != 0)
                {
                    switch (input[0])
                    {
                        case "Mouse":
                            Mouse mouse = new Mouse(input[1], input[0], double.Parse(input[2]), input[3]);
                            listOfAnimals.Add(mouse);
                            break;
                        case "Zebra":
                            Zebra zebra = new Zebra(input[1], input[0], double.Parse(input[2]), input[3]);
                            listOfAnimals.Add(zebra);
                            break;
                        case "Cat":
                            Cat cat = new Cat(input[1], input[0], double.Parse(input[2]), input[3], input[4]);
                            listOfAnimals.Add(cat);
                            break;
                        case "Tiger":
                            Tiger tiger = new Tiger(input[1], input[0], double.Parse(input[2]), input[3]);
                            listOfAnimals.Add(tiger);
                            break;
                    }
                }
                else
                {
                    if (input[0] == "Vegetable")
                    {
                        Vegetable veg = new Vegetable(int.Parse(input[1]));
                        listOfFood.Add(veg);
                    }
                    else
                    {
                        Meat meat = new Meat(int.Parse(input[1]));
                        listOfFood.Add(meat);
                    }
                }


                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                counter++;
            }
            Console.WriteLine();

            var index = 0;

            for (int i = 0; i < listOfAnimals.Count; i++)
            {
                listOfAnimals[index].MakeSound();
                listOfAnimals[index].Eat(listOfFood[index], listOfFood[index].Quantity);
                Console.WriteLine(listOfAnimals[index].ToString());
                index++;
            }
        }
    }
}
