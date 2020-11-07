using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlaylistAndrijaHanga
{
    public partial class Form1 : Form
    {
        private static  BindingList<Song> _songs;
        private static BindingList<Song> _playlistSongs;
        public Form1()
        {
            InitializeComponent();
            _songs = new BindingList<Song>();
            _playlistSongs = new BindingList<Song>();
            _songs.Add(new Song() {Title="Billie Jeans", Artist="Micheal Jackson",Genre=Genre.Pop});
            _songs.Add(new Song() { Title = "Last Friday Night", Artist = "Katty Perry",Genre=Genre.Pop });
            _songs.Add(new Song() { Title = "Last Friday Night123", Artist = "Katty Perry", Genre = Genre.Pop });
            listBoxAllSongs.DataSource = _songs;
            listBoxAllSongs.DisplayMember = "TitleArtist";
            listBoxSelectedSongs.DataSource = _playlistSongs;
            listBoxSelectedSongs.DisplayMember = "TitleArtist";
            this.comboBoxGenrePlaylist.DataSource = Enum.GetValues(typeof(Genre));
            this.comboBoxGenrePlaylist.SelectedValueChanged += ComboBoxGenrePlaylist_SelectedValueChanged;
            this.comboBoxArtistFilter.DataSource = _songs.Select(x=>x.Artist).Distinct().ToList();
            this.comboBoxArtistFilter.DisplayMember = "Artist";

        }

        private void ComboBoxGenrePlaylist_SelectedValueChanged(object sender, EventArgs e)
        {
            var filteredSongs = _songs.Where(x => x.Genre == (Genre)comboBoxGenrePlaylist.SelectedItem);
            listBoxAllSongs.DataSource = new BindingList<Song>(filteredSongs.ToList());
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSongForm f1 = new AddSongForm(_songs);
            f1.Closed += AddSongForm_Closed;
            f1.Show();

            
            


        }

        private void AddSongForm_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMoveSong_Click(object sender, EventArgs e)
        {
            _playlistSongs.Add((Song)listBoxAllSongs.SelectedItem);
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            
            _playlistSongs.Remove((Song)listBoxSelectedSongs.SelectedItem);
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            _songs.Remove((Song)listBoxAllSongs.SelectedItem);
        }
    }
}
