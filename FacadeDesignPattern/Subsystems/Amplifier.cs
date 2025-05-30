namespace FacadeDesignPattern.Subsystems;

public class Amplifier
{
    public void On() 
        => Console.WriteLine("Amplifier is ON");
    public void SetVolume(int level) 
        => Console.WriteLine($"Volume set to {level}");
}
