using FacadeDesignPattern.Subsystems;

namespace FacadeDesignPattern.Facades;

public class HomeTeaterFacade : IHomeTeaterFacade
{
    #region Fields
    private readonly DVDPlayer _dvd;
    private readonly Projector _projector;
    private readonly Amplifier _amp;
    private readonly Lights _lights;
    #endregion

    public HomeTeaterFacade()
    {
        _dvd = new DVDPlayer();
        _projector = new Projector();
        _amp = new Amplifier();
        _lights = new Lights();
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie");
        _lights.Dim(10);
        _projector.On();
        _projector.SetInput("DVD");
        _amp.On();
        _amp.SetVolume(5);
        _dvd.On();
        _dvd.Play(movie);
    }
}
