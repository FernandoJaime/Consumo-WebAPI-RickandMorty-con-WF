namespace RickandMorty.Views
{
    partial class InfoCharacter
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnCerrar = new Button();
            pictureCharacter = new PictureBox();
            lblNombre = new Label();
            lblStatus = new Label();
            lblSpecie = new Label();
            lblGender = new Label();
            lblCreated = new Label();
            PanelLocation = new Panel();
            lblDimensionPanel = new Label();
            lblTypePanel = new Label();
            lblNamePanel = new Label();
            btnLocation = new Button();
            DGVepisodes = new DataGridView();
            btnEpisode = new Button();
            name = new DataGridViewTextBoxColumn();
            air_date = new DataGridViewTextBoxColumn();
            episode = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureCharacter).BeginInit();
            PanelLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVepisodes).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.Lime;
            btnCerrar.Location = new Point(988, 651);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(62, 28);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureCharacter
            // 
            pictureCharacter.BackColor = Color.Transparent;
            pictureCharacter.Location = new Point(12, 12);
            pictureCharacter.Name = "pictureCharacter";
            pictureCharacter.Size = new Size(300, 300);
            pictureCharacter.TabIndex = 9;
            pictureCharacter.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Lime;
            lblNombre.Location = new Point(329, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(109, 25);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "lblNombre";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Lime;
            lblStatus.Location = new Point(12, 338);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(73, 21);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status:";
            // 
            // lblSpecie
            // 
            lblSpecie.AutoSize = true;
            lblSpecie.BackColor = Color.Transparent;
            lblSpecie.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecie.ForeColor = Color.Lime;
            lblSpecie.Location = new Point(12, 377);
            lblSpecie.Name = "lblSpecie";
            lblSpecie.Size = new Size(69, 21);
            lblSpecie.TabIndex = 12;
            lblSpecie.Text = "Specie:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.Lime;
            lblGender.Location = new Point(12, 416);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(75, 21);
            lblGender.TabIndex = 13;
            lblGender.Text = "Gender:";
            // 
            // lblCreated
            // 
            lblCreated.AutoSize = true;
            lblCreated.BackColor = Color.Transparent;
            lblCreated.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreated.ForeColor = Color.Lime;
            lblCreated.Location = new Point(12, 458);
            lblCreated.Name = "lblCreated";
            lblCreated.Size = new Size(82, 21);
            lblCreated.TabIndex = 14;
            lblCreated.Text = "Created:";
            // 
            // PanelLocation
            // 
            PanelLocation.BackColor = Color.Transparent;
            PanelLocation.BorderStyle = BorderStyle.FixedSingle;
            PanelLocation.Controls.Add(lblDimensionPanel);
            PanelLocation.Controls.Add(lblTypePanel);
            PanelLocation.Controls.Add(lblNamePanel);
            PanelLocation.ForeColor = Color.Lime;
            PanelLocation.Location = new Point(726, 110);
            PanelLocation.Name = "PanelLocation";
            PanelLocation.Size = new Size(324, 113);
            PanelLocation.TabIndex = 16;
            // 
            // lblDimensionPanel
            // 
            lblDimensionPanel.AutoSize = true;
            lblDimensionPanel.BackColor = Color.Transparent;
            lblDimensionPanel.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDimensionPanel.ForeColor = Color.Lime;
            lblDimensionPanel.Location = new Point(3, 83);
            lblDimensionPanel.Name = "lblDimensionPanel";
            lblDimensionPanel.Size = new Size(100, 21);
            lblDimensionPanel.TabIndex = 21;
            lblDimensionPanel.Text = "Dimension:";
            // 
            // lblTypePanel
            // 
            lblTypePanel.AutoSize = true;
            lblTypePanel.BackColor = Color.Transparent;
            lblTypePanel.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTypePanel.ForeColor = Color.Lime;
            lblTypePanel.Location = new Point(3, 46);
            lblTypePanel.Name = "lblTypePanel";
            lblTypePanel.Size = new Size(56, 21);
            lblTypePanel.TabIndex = 20;
            lblTypePanel.Text = "Type:";
            // 
            // lblNamePanel
            // 
            lblNamePanel.AutoSize = true;
            lblNamePanel.BackColor = Color.Transparent;
            lblNamePanel.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamePanel.ForeColor = Color.Lime;
            lblNamePanel.Location = new Point(3, 9);
            lblNamePanel.Name = "lblNamePanel";
            lblNamePanel.Size = new Size(64, 21);
            lblNamePanel.TabIndex = 19;
            lblNamePanel.Text = "Name:";
            // 
            // btnLocation
            // 
            btnLocation.BackColor = Color.Transparent;
            btnLocation.FlatStyle = FlatStyle.Flat;
            btnLocation.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocation.ForeColor = Color.Lime;
            btnLocation.Location = new Point(726, 76);
            btnLocation.Name = "btnLocation";
            btnLocation.Size = new Size(106, 28);
            btnLocation.TabIndex = 18;
            btnLocation.Text = "Location";
            btnLocation.UseVisualStyleBackColor = false;
            btnLocation.Click += btnLocation_Click;
            // 
            // DGVepisodes
            // 
            DGVepisodes.AllowUserToAddRows = false;
            DGVepisodes.AllowUserToDeleteRows = false;
            DGVepisodes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DGVepisodes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVepisodes.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("MV Boli", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVepisodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVepisodes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVepisodes.Columns.AddRange(new DataGridViewColumn[] { name, air_date, episode });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("MV Boli", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVepisodes.DefaultCellStyle = dataGridViewCellStyle2;
            DGVepisodes.Location = new Point(294, 529);
            DGVepisodes.MultiSelect = false;
            DGVepisodes.Name = "DGVepisodes";
            DGVepisodes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("MV Boli", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGVepisodes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGVepisodes.RowHeadersVisible = false;
            DGVepisodes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVepisodes.Size = new Size(482, 150);
            DGVepisodes.TabIndex = 19;
            // 
            // btnEpisode
            // 
            btnEpisode.BackColor = Color.Transparent;
            btnEpisode.FlatStyle = FlatStyle.Flat;
            btnEpisode.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEpisode.ForeColor = Color.Lime;
            btnEpisode.Location = new Point(182, 529);
            btnEpisode.Name = "btnEpisode";
            btnEpisode.Size = new Size(106, 28);
            btnEpisode.TabIndex = 20;
            btnEpisode.Text = "Episodes";
            btnEpisode.UseVisualStyleBackColor = false;
            btnEpisode.Click += btnEpisode_Click;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // air_date
            // 
            air_date.DataPropertyName = "air_date";
            air_date.HeaderText = "Date";
            air_date.Name = "air_date";
            air_date.ReadOnly = true;
            // 
            // episode
            // 
            episode.DataPropertyName = "episode";
            episode.HeaderText = "Episode";
            episode.Name = "episode";
            episode.ReadOnly = true;
            // 
            // InfoCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.ImageBack;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 689);
            ControlBox = false;
            Controls.Add(btnEpisode);
            Controls.Add(DGVepisodes);
            Controls.Add(btnLocation);
            Controls.Add(PanelLocation);
            Controls.Add(lblCreated);
            Controls.Add(lblGender);
            Controls.Add(lblSpecie);
            Controls.Add(lblStatus);
            Controls.Add(lblNombre);
            Controls.Add(pictureCharacter);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "InfoCharacter";
            StartPosition = FormStartPosition.CenterScreen;
            Load += InfoCharacter_Load;
            ((System.ComponentModel.ISupportInitialize)pictureCharacter).EndInit();
            PanelLocation.ResumeLayout(false);
            PanelLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVepisodes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCerrar;
        private PictureBox pictureCharacter;
        private Label lblNombre;
        private Label lblStatus;
        private Label lblSpecie;
        private Label lblGender;
        private Label lblCreated;
        private Panel PanelLocation;
        private Button btnLocation;
        private Label lblDimensionPanel;
        private Label lblTypePanel;
        private Label lblNamePanel;
        private DataGridView DGVepisodes;
        private Button btnEpisode;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn air_date;
        private DataGridViewTextBoxColumn episode;
    }
}