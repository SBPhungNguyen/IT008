using System;
interface IAbility
{

}
interface IThinking : IAbility
{
    void thinking_behavior();
}
interface IIntelligent : IAbility
{
    void intelligent_behavior();
}
class Mamal
{
    protected string characteristics;
}
class Whale : Mamal
{
    public Whale()
    {
        Console.WriteLine("I am a whale");
    }
}
class Human : Mamal, IIntelligent, IThinking
{
    public Human()
    {
        Console.WriteLine("I am a human");
    }
    public void thinking_behavior()
    {
        Console.WriteLine("I can think");
    }
    public void intelligent_behavior()
    {
        Console.WriteLine("I am intelligent");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Mamal[] mamal = new Mamal[2];
        Console.WriteLine("\tCreate a whale");
        mamal[0] = new Whale();
        Console.WriteLine("\tCreate a human");
        mamal[1] = new Human();
        ((Human)mamal[1]).thinking_behavior();
        ((Human)mamal[1]).intelligent_behavior();
    }
}