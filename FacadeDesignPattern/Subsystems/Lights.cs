namespace FacadeDesignPattern.Subsystems;

public class Lights
{
    public void Dim(int level) => 
        Console.WriteLine($"Lights dimmed to {level}%");
}
