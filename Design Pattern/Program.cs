using AbstractFactoryDesignPattern;
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Using MP3 & MP4 formats:");
        var mp3mp4Factory = new MP3MP4Factory();
        var mp3mp4App = new MediaApplication(mp3mp4Factory);
        mp3mp4App.Run("song.mp3", "video.mp4");
        Console.WriteLine("\nUsing WAV & AVI formats:");
        var wavaviFactory = new WAVAVIFactory();
        var wavaviApp = new MediaApplication(wavaviFactory);
        wavaviApp.Run("song.wav", "video.avi");
        Console.ReadKey();
    }
}