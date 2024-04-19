using System;

// Abstract Products
public interface IAudioProcessor
{
    void ProcessAudio(string file);
}

public interface IVideoProcessor
{
    void ProcessVideo(string file);
}

// Concrete Products for MP3 & MP4
public class MP3Processor : IAudioProcessor
{
    public void ProcessAudio(string file)
    {
        Console.WriteLine($"Processing MP3 audio file: {file}");
    }
}

public class MP4Processor : IVideoProcessor
{
    public void ProcessVideo(string file)
    {
        Console.WriteLine($"Processing MP4 video file: {file}");
    }
}

// Concrete Products for WAV & AVI
public class WAVProcessor : IAudioProcessor
{
    public void ProcessAudio(string file)
    {
        Console.WriteLine($"Processing WAV audio file: {file}");
    }
}

public class AVIProcessor : IVideoProcessor
{
    public void ProcessVideo(string file)
    {
        Console.WriteLine($"Processing AVI video file: {file}");
    }
}

// Client Code without Abstract Factory
public class MediaApplicationWithoutFactory
{
    private readonly IAudioProcessor _audioProcessor;
    private readonly IVideoProcessor _videoProcessor;

    public MediaApplicationWithoutFactory(IAudioProcessor audioProcessor, IVideoProcessor videoProcessor)
    {
        _audioProcessor = audioProcessor;
        _videoProcessor = videoProcessor;
    }

    public void Run(string audioFile, string videoFile)
    {
        _audioProcessor.ProcessAudio(audioFile);
        _videoProcessor.ProcessVideo(videoFile);
    }
}

