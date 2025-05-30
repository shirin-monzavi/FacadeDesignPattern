namespace FacadeDesignPattern.Subsystems;

public class DVDPlayer
{
    public void On() =>
        Console.WriteLine("DVD Player is ON");

    public void Play(string movieName) =>
        Console.WriteLine($"Playing movie {movieName}");
}
