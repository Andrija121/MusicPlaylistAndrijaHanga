namespace MusicPlaylistAndrijaHanga
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // comboBoxGenrePlaylist
            // 
            this.comboBoxGenrePlaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenrePlaylist.FormattingEnabled = true;
            this.comboBoxGenrePlaylist.Location = new System.Drawing.Point(34, 72);
            this.comboBoxGenrePlaylist.Name = "comboBoxGenrePlaylist";
            this.comboBoxGenrePlaylist.Size = new System.Drawing.Size(251, 28);
            this.comboBoxGenrePlaylist.TabIndex = 1;
            // 
            // listBoxAllSongs
            // 
            this.listBoxAllSongs.FormattingEnabled = true;
            this.listBoxAllSongs.ItemHeight = 20;
            this.listBoxAllSongs.Location = new System.Drawing.Point(34, 156);
            this.listBoxAllSongs.Name = "listBoxAllSongs";
            this.listBoxAllSongs.Size = new System.Drawing.Size(251, 264);
            this.listBoxAllSongs.TabIndex = 2;
            // 
            // listBoxSelectedSongs
            // 
            this.listBoxSelectedSongs.FormattingEnabled = true;
            this.listBoxSelectedSongs.ItemHeight = 20;
            this.listBoxSelectedSongs.Location = new System.Drawing.Point(487, 156);
            this.listBoxSelectedSongs.Name = "listBoxSelectedSongs";
            this.listBoxSelectedSongs.Size = new System.Drawing.Size(251, 264);
            this.listBoxSelectedSongs.TabIndex = 3;
            // 
            // btnMoveSong
            // 
            this.btnMoveSong.Location = new System.Drawing.Point(329, 184);
            this.btnMoveSong.Name = "btnMoveSong";
            this.btnMoveSong.Size = new System.Drawing.Size(136, 75);
            this.btnMoveSong.TabIndex = 4;
            this.btnMoveSong.Text = "Add song to your playlist";
            this.btnMoveSong.UseVisualStyleBackColor = true;
            this.btnMoveSong.Click += new System.EventHandler(this.btnMoveSong_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(329, 295);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(136, 75);
            this.btnRemoveSong.TabIndex = 5;
            this.btnRemoveSong.Text = "Remove song from your playlist";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(34, 426);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(106, 69);
            this.btnAddSong.TabIndex = 7;
            this.btnAddSong.Text = "Add new song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.Location = new System.Drawing.Point(179, 426);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(106, 69);
            this.btnDeleteSong.TabIndex = 6;
            this.btnDeleteSong.Text = "Remove song";
            this.btnDeleteSong.UseVisualStyleBackColor = true;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "All Songs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Playlist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Duration";
            // 
            // comboBoxArtistFilter
            // 
            this.comboBoxArtistFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArtistFilter.FormattingEnabled = true;
            this.comboBoxArtistFilter.Location = new System.Drawing.Point(34, 23);
            this.comboBoxArtistFilter.Name = "comboBoxArtistFilter";
            this.comboBoxArtistFilter.Size = new System.Drawing.Size(251, 28);
            this.comboBoxArtistFilter.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 567);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Playlist";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

