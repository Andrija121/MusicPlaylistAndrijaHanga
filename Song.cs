namespace MusicPlaylistAndrijaHanga
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public Genre Genre { get; set; }

        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public string DisplayProp => Title + " - " + Artist + " " + Minutes + ":" + Seconds;
    }

    public enum Genre
    {
        Pop = 0,
        Rock = 1,
        Jazz = 2
    }
}