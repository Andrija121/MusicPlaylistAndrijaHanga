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
    public partial class AddSongForm : Form
    {
        private readonly BindingList<Song> _songs;
        public AddSongForm(BindingList<Song> songs)
        {
            InitializeComponent();
            _songs = songs;
            this.comboBoxGenre.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            _songs.Add(new Song() {Title =txtboxSongName.Text, Artist=txtboxArtist.Text, Genre = (Genre)comboBoxGenre.SelectedValue });
            this.Close();
        }
    }
}
