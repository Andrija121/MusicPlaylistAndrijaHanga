namespace MusicPlaylistAndrijaHanga
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxGenrePlaylist = new System.Windows.Forms.ComboBox();
            this.listBoxAllSongs = new System.Windows.Forms.ListBox();
            this.listBoxSelectedSongs = new System.Windows.Forms.ListBox();
            this.btnMoveSong = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxArtistFilter = new System.Windows.Forms.ComboBox();
            this.totalDurationLbl = new System.Windows.Forms.Label();
            this.sortSongsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxGenrePlaylist
            // 
            this.comboBoxGenrePlaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenrePlaylist.FormattingEnabled = true;
            this.comboBoxGenrePlaylist.Location = new System.Drawing.Point(51, 56);
            this.comboBoxGenrePlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGenrePlaylist.Name = "comboBoxGenrePlaylist";
            this.comboBoxGenrePlaylist.Size = new System.Drawing.Size(169, 21);
            this.comboBoxGenrePlaylist.TabIndex = 1;
            // 
            // listBoxAllSongs
            // 
            this.listBoxAllSongs.FormattingEnabled = true;
            this.listBoxAllSongs.Location = new System.Drawing.Point(23, 101);
            this.listBoxAllSongs.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAllSongs.Name = "listBoxAllSongs";
            this.listBoxAllSongs.Size = new System.Drawing.Size(235, 173);
            this.listBoxAllSongs.TabIndex = 2;
            // 
            // listBoxSelectedSongs
            // 
            this.listBoxSelectedSongs.FormattingEnabled = true;
            this.listBoxSelectedSongs.Location = new System.Drawing.Point(399, 101);
            this.listBoxSelectedSongs.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSelectedSongs.Name = "listBoxSelectedSongs";
            this.listBoxSelectedSongs.Size = new System.Drawing.Size(235, 173);
            this.listBoxSelectedSongs.TabIndex = 3;
            // 
            // btnMoveSong
            // 
            this.btnMoveSong.Location = new System.Drawing.Point(285, 119);
            this.btnMoveSong.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveSong.Name = "btnMoveSong";
            this.btnMoveSong.Size = new System.Drawing.Size(91, 49);
            this.btnMoveSong.TabIndex = 4;
            this.btnMoveSong.Text = "Add song to your playlist";
            this.btnMoveSong.UseVisualStyleBackColor = true;
            this.btnMoveSong.Click += new System.EventHandler(this.btnMoveSong_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(285, 194);
            this.btnRemoveSong.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(91, 49);
            this.btnRemoveSong.TabIndex = 5;
            this.btnRemoveSong.Text = "Remove song from your playlist";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(23, 276);
            this.btnAddSong.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(71, 45);
            this.btnAddSong.TabIndex = 7;
            this.btnAddSong.Text = "Add new song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.Location = new System.Drawing.Point(106, 276);
            this.btnDeleteSong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(71, 45);
            this.btnDeleteSong.TabIndex = 6;
            this.btnDeleteSong.Text = "Remove song";
            this.btnDeleteSong.UseVisualStyleBackColor = true;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "All Songs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Playlist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total duration";
            // 
            // comboBoxArtistFilter
            // 
            this.comboBoxArtistFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArtistFilter.FormattingEnabled = true;
            this.comboBoxArtistFilter.Location = new System.Drawing.Point(51, 24);
            this.comboBoxArtistFilter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxArtistFilter.Name = "comboBoxArtistFilter";
            this.comboBoxArtistFilter.Size = new System.Drawing.Size(169, 21);
            this.comboBoxArtistFilter.TabIndex = 11;
            // 
            // totalDurationLbl
            // 
            this.totalDurationLbl.AutoSize = true;
            this.totalDurationLbl.Location = new System.Drawing.Point(590, 276);
            this.totalDurationLbl.Name = "totalDurationLbl";
            this.totalDurationLbl.Size = new System.Drawing.Size(0, 13);
            this.totalDurationLbl.TabIndex = 12;
            // 
            // sortSongsBtn
            // 
            this.sortSongsBtn.Location = new System.Drawing.Point(187, 276);
            this.sortSongsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sortSongsBtn.Name = "sortSongsBtn";
            this.sortSongsBtn.Size = new System.Drawing.Size(71, 45);
            this.sortSongsBtn.TabIndex = 13;
            this.sortSongsBtn.Text = "Sort songs";
            this.sortSongsBtn.UseVisualStyleBackColor = true;
            this.sortSongsBtn.Click += new System.EventHandler(this.sortSongsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 395);
            this.Controls.Add(this.sortSongsBtn);
            this.Controls.Add(this.totalDurationLbl);
            this.Controls.Add(this.comboBoxArtistFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnMoveSong);
            this.Controls.Add(this.listBoxSelectedSongs);
            this.Controls.Add(this.listBoxAllSongs);
            this.Controls.Add(this.comboBoxGenrePlaylist);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGenrePlaylist;
        private System.Windows.Forms.ListBox listBoxAllSongs;
        private System.Windows.Forms.ListBox listBoxSelectedSongs;
        private System.Windows.Forms.Button btnMoveSong;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxArtistFilter;
        private System.Windows.Forms.Label totalDurationLbl;
        private System.Windows.Forms.Button sortSongsBtn;
    }
}

