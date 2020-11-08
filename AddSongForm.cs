using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MusicPlaylistAndrijaHanga
{
    public partial class AddSongForm : Form
    {
        private readonly BindingList<Song> _songs;

        public AddSongForm(BindingList<Song> songs)
        {
            InitializeComponent();
            _songs = songs;
            comboBoxGenre.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            _songs.Add(new Song
            {
                Title = txtboxSongName.Text, Artist = txtboxArtist.Text, Genre = (Genre) comboBoxGenre.SelectedValue,
                Minutes = Convert.ToInt32(minuteControl.Value), Seconds = Convert.ToInt32(secondsControl.Value)
            });
            Close();
        }
    }
}