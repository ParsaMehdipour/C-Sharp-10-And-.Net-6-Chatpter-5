using Funtionalities.Interfaces;

namespace Funtionalities;
public class DvdPlayer : IPlayable
{
    public void Pause()
    {
        Console.WriteLine("DvdPlayer Pausing");
    }

    public void Play()
    {
        Console.WriteLine("DvdPlayer Playing");
    }

    //we could override the default
    //implementation of Stop by implementing it
    //public void Stop()
    //{
    //    Console.WriteLine("DvdPlayer Stoping");
    //}
}
