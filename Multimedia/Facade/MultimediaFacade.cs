namespace Multimedia.Facade;

using Subsystem;

internal class MultimediaFacade
{
    private readonly VideoPlayer _videoPlayer = new();
    private readonly AudioPlayer _audioPlayer = new();
    private readonly Display _display = new();
    private readonly SubtitlePlayer _subtitlePlayer = new();
    private readonly StreamingService _streamingService = new();

    public void WatchMovie(string movie, string audioTrack, string subtitles)
    {
        _streamingService.StreamContent(movie);
        _videoPlayer.PlayVideo(movie);
        _audioPlayer.PlayAudio(audioTrack);
        _subtitlePlayer.DisplaySubtitles(subtitles);
        _display.Show("Enjoy the movie on the big screen!");
    }

    public void ListenToMusic(string song)
    {
        _streamingService.StreamContent(song);
        _audioPlayer.PlayAudio(song);
        _display.Show("Feel the music with visualizations on the display.");
    }
}