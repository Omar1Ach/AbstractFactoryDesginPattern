using System;
namespace AbstractFactoryDesignPattern
{
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
    // Abstract Factory
    public interface IMediaFactory
    {
        IAudioProcessor CreateAudioProcessor();
        IVideoProcessor CreateVideoProcessor();
    }
    // Concrete Factories
    public class MP3MP4Factory : IMediaFactory
    {
        public IAudioProcessor CreateAudioProcessor() => new MP3Processor();
        public IVideoProcessor CreateVideoProcessor() => new MP4Processor();
    }
    public class WAVAVIFactory : IMediaFactory
    {
        public IAudioProcessor CreateAudioProcessor() => new WAVProcessor();
        public IVideoProcessor CreateVideoProcessor() => new AVIProcessor();
    }
    // Client Code
    public class MediaApplication
    {
        private readonly IAudioProcessor _audioProcessor;
        private readonly IVideoProcessor _videoProcessor;
        public MediaApplication(IMediaFactory factory)
        {
            _audioProcessor = factory.CreateAudioProcessor();
            _videoProcessor = factory.CreateVideoProcessor();
        }
        public void Run(string audioFile, string videoFile)
        {
            _audioProcessor.ProcessAudio(audioFile);
            _videoProcessor.ProcessVideo(videoFile);
        }
    }
}