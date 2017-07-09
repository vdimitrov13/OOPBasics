public abstract class Animal
{
    private string animalName;
    private string animalType;
    private double animalWeight;
    private int foodEaten = 0;

    public Animal(string name, string type, double weight)
    {
        this.AnimalName = name;
        this.AnimalType = type;
        this.AnimalWeight = weight;
    }

    public int FoodEaten
    {
        get { return foodEaten; }
        set { foodEaten = value; }
    }

    public double AnimalWeight
    {
        get { return animalWeight; }
        set { animalWeight = value; }
    }

    public string AnimalType
    {
        get { return animalType; }
        set { animalType = value; }
    }

    public string AnimalName
    {
        get { return animalName; }
        set { animalName = value; }
    }

    public virtual void MakeSound()
    {       
    }

    public virtual void Eat(Food food, int quantity)
    {
        this.FoodEaten += quantity;
    }

    public override string ToString()
    {
        return $"{this.animalType}[{this.animalName}, {this.animalWeight}, ";
    }
}
