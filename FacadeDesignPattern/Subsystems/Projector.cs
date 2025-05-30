namespace FacadeDesignPattern.Subsystems;

public class Projector
{
    public void On()
        => Console.WriteLine("Projector is ON");

    public void SetInput(string input) => 
        Console.WriteLine($"Projector input set to {input}");
}
