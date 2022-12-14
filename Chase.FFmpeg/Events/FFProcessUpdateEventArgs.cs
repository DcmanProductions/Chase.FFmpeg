namespace Chase.FFmpeg.Events;

/// <summary>
/// Runs when ffmpeg changes conversion status
/// </summary>
public class FFProcessUpdateEventArgs : EventArgs
{
    /// <summary>
    /// The bitrate that the video is being processed at
    /// </summary>
    public float AverageBitrate { get; set; }

    /// <summary>
    /// The number of frames already processed
    /// </summary>
    public uint FramesProcessed { get; set; }

    /// <summary>
    /// The percentage of the video has been processed
    /// </summary>
    public float Percentage { get; set; }
    /// <summary>
    /// The speed that the video is processing at
    /// </summary>
    public float Speed { get; set; }
}
