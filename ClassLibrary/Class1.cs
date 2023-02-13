namespace ClassLibrary
{
    public class Unit
    {
        string name;
        public Unit(string name)
        {
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine($"Unit name {name}");
        }
    }
}