using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MusicPlaylistAndrijaHanga
{
    public partial class MainForm : Form
    {
        private static BindingList<Song> _songs;
        private static BindingList<Song> _playlistSongs;
        private bool _sortOrderAsc = true;


        public MainForm()
        {
            InitializeComponent();
            _songs = new BindingList<Song>();
            _playlistSongs = new BindingList<Song>();

            AddSongsToAvailableSongs();

            listBoxAllSongs.DataSource = _songs;
            listBoxAllSongs.DisplayMember = "DisplayProp";
            listBoxSelectedSongs.DataSource = _playlistSongs;
            listBoxSelectedSongs.DisplayMember = "DisplayProp";

            PopulateGenreComboBox();
            PopulateArtistComboBox();

            totalDurationLbl.Text = TimeSpan.Zero.ToString("c");
        }

        private static void AddSongsToAvailableSongs()
        {
            _songs.Add(new Song
                {Title = "Billie Jeans", Artist = "Michael Jackson", Genre = Genre.Pop, Minutes = 3, Seconds = 45});
            _songs.Add(new Song
                {Title = "Last Friday Night", Artist = "Katy Perry", Genre = Genre.Rock, Minutes = 4, Seconds = 12});
            _songs.Add(new Song
                {Title = "Last Friday Night123", Artist = "Katy Perry", Genre = Genre.Pop, Minutes = 2, Seconds = 44});
        }

        private void PopulateArtistComboBox()
        {
            var artistList = new List<string> {""};
            artistList.AddRange(_songs.Select(x => x.Artist).Distinct().ToList());
            comboBoxArtistFilter.DataSource = artistList;

            comboBoxArtistFilter.SelectedValueChanged += ComboBoxArtistFilter_SelectedValueChanged;
        }


        private void PopulateGenreComboBox()
        {
            var data = Enum.GetValues(typeof(Genre)).Cast<Enum>().ToList<object>();

            data.Insert(0, "");


            comboBoxGenrePlaylist.DataSource = data;
            comboBoxGenrePlaylist.SelectedValueChanged += ComboBoxGenrePlaylist_SelectedValueChanged;
        }

        private void ComboBoxArtistFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterSongs();
        }

        private void FilterSongs()
        {
            if (comboBoxArtistFilter.SelectedValue.ToString() == "" &&
                comboBoxGenrePlaylist.SelectedItem.GetType() != typeof(Genre))
            {
                listBoxAllSongs.DataSource = _songs;
            }
            else if (comboBoxArtistFilter.SelectedValue.ToString() != "" &&
                     comboBoxGenrePlaylist.SelectedItem.GetType() == typeof(Genre))
            {
                var filteredSongs = _songs.Where(x =>
                    x.Genre == (Genre) comboBoxGenrePlaylist.SelectedItem &&
                    x.Artist == comboBoxArtistFilter.SelectedValue.ToString());
                listBoxAllSongs.DataSource = new BindingList<Song>(filteredSongs.ToList());
            }
            else if (comboBoxArtistFilter.SelectedValue.ToString() != "")

            {
                var filteredSongs = _songs.Where(x => x.Artist == comboBoxArtistFilter.SelectedValue.ToString());
                listBoxAllSongs.DataSource = new BindingList<Song>(filteredSongs.ToList());
            }
            else if (comboBoxGenrePlaylist.SelectedItem.GetType() == typeof(Genre))
            {
                var filteredSongs = _songs.Where(x => x.Genre == (Genre) comboBoxGenrePlaylist.SelectedItem);
                listBoxAllSongs.DataSource = new BindingList<Song>(filteredSongs.ToList());
            }
        }

        private void ComboBoxGenrePlaylist_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterSongs();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            Hide();
            var f1 = new AddSongForm(_songs);
            f1.Closed += AddSongForm_Closed;
            f1.Show();
        }

        private void AddSongForm_Closed(object sender, EventArgs e)
        {
            PopulateArtistComboBox();
            Show();
        }

        private void btnMoveSong_Click(object sender, EventArgs e)
        {
            var song = listBoxAllSongs.SelectedItem as Song;
            if (song != null)
            {
                _playlistSongs.Add(song);

                CalculatePlaylistDuration();
            }
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            var song = listBoxSelectedSongs.SelectedItem as Song;
            if (song != null)
            {
                _playlistSongs.RemoveAt(listBoxSelectedSongs.SelectedIndex);
                CalculatePlaylistDuration();
            }
        }

        private void CalculatePlaylistDuration()
        {
            var totalSeconds = 0;
            foreach (var song in _playlistSongs)
            {
                totalSeconds += song.Seconds;
                totalSeconds += song.Minutes * 60;
            }

            totalDurationLbl.Text = TimeSpan.FromSeconds(totalSeconds).ToString("c");
        }


        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            _songs.Remove((Song) listBoxAllSongs.SelectedItem);
            FilterSongs();
        }

        private void sortSongsBtn_Click(object sender, EventArgs e)
        {
            _songs = _sortOrderAsc
                ? new BindingList<Song>(_songs.OrderBy(x => x.Artist).ThenBy(x => x.Title).ToList())
                : new BindingList<Song>(_songs.OrderByDescending(x => x.Artist).ThenByDescending(x => x.Title)
                    .ToList());
            _sortOrderAsc = !_sortOrderAsc;
            listBoxAllSongs.DataSource = _songs;
            FilterSongs();
        }
    }
}