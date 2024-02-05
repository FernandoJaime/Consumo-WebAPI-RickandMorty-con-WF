namespace RickandMorty
{
    partial class PagesCharacters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagesCharacters));
            PanelDeImages = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            ComboGender = new ComboBox();
            CheckGender = new CheckBox();
            CheckName = new CheckBox();
            btnQuitarFiltros = new Button();
            ComboStatus = new ComboBox();
            btnFiltrar = new Button();
            CheckStatus = new CheckBox();
            txtName = new TextBox();
            btnBack = new Button();
            btnNext = new Button();
            btnVolverMenu = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelDeImages
            // 
            PanelDeImages.BackColor = Color.Transparent;
            PanelDeImages.Location = new Point(12, 98);
            PanelDeImages.Name = "PanelDeImages";
            PanelDeImages.Size = new Size(1037, 554);
            PanelDeImages.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(ComboGender);
            groupBox1.Controls.Add(CheckGender);
            groupBox1.Controls.Add(CheckName);
            groupBox1.Controls.Add(btnQuitarFiltros);
            groupBox1.Controls.Add(ComboStatus);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(CheckStatus);
            groupBox1.Controls.Add(txtName);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Lime;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 80);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // ComboGender
            // 
            ComboGender.BackColor = Color.FromArgb(64, 64, 64);
            ComboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboGender.Enabled = false;
            ComboGender.FlatStyle = FlatStyle.Flat;
            ComboGender.ForeColor = Color.Lime;
            ComboGender.FormattingEnabled = true;
            ComboGender.Items.AddRange(new object[] { "female", "male", "genderless", "unknow" });
            ComboGender.Location = new Point(523, 32);
            ComboGender.Name = "ComboGender";
            ComboGender.Size = new Size(121, 25);
            ComboGender.TabIndex = 9;
            // 
            // CheckGender
            // 
            CheckGender.AutoSize = true;
            CheckGender.BackColor = Color.Transparent;
            CheckGender.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckGender.ForeColor = Color.Lime;
            CheckGender.Location = new Point(444, 34);
            CheckGender.Name = "CheckGender";
            CheckGender.Size = new Size(77, 21);
            CheckGender.TabIndex = 8;
            CheckGender.Text = "Gender:";
            CheckGender.UseVisualStyleBackColor = false;
            CheckGender.CheckedChanged += CheckGender_CheckedChanged;
            // 
            // CheckName
            // 
            CheckName.AutoSize = true;
            CheckName.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckName.ForeColor = Color.Lime;
            CheckName.Location = new Point(20, 34);
            CheckName.Name = "CheckName";
            CheckName.Size = new Size(80, 21);
            CheckName.TabIndex = 7;
            CheckName.Text = "Nombre:";
            CheckName.UseVisualStyleBackColor = true;
            CheckName.CheckedChanged += CheckName_CheckedChanged;
            // 
            // btnQuitarFiltros
            // 
            btnQuitarFiltros.BackColor = Color.Transparent;
            btnQuitarFiltros.FlatStyle = FlatStyle.Flat;
            btnQuitarFiltros.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuitarFiltros.ForeColor = Color.Lime;
            btnQuitarFiltros.Location = new Point(693, 48);
            btnQuitarFiltros.Name = "btnQuitarFiltros";
            btnQuitarFiltros.Size = new Size(114, 26);
            btnQuitarFiltros.TabIndex = 6;
            btnQuitarFiltros.Text = "Quitar filtros";
            btnQuitarFiltros.UseVisualStyleBackColor = false;
            btnQuitarFiltros.Click += btnQuitarFiltros_Click;
            // 
            // ComboStatus
            // 
            ComboStatus.BackColor = Color.FromArgb(64, 64, 64);
            ComboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboStatus.Enabled = false;
            ComboStatus.FlatStyle = FlatStyle.Flat;
            ComboStatus.ForeColor = Color.Lime;
            ComboStatus.FormattingEnabled = true;
            ComboStatus.Items.AddRange(new object[] { "alive", "dead", "unknown" });
            ComboStatus.Location = new Point(317, 32);
            ComboStatus.Name = "ComboStatus";
            ComboStatus.Size = new Size(121, 25);
            ComboStatus.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.Transparent;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.Lime;
            btnFiltrar.Location = new Point(693, 16);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(114, 26);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Aplicar filtros";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // CheckStatus
            // 
            CheckStatus.AutoSize = true;
            CheckStatus.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckStatus.ForeColor = Color.Lime;
            CheckStatus.Location = new Point(240, 34);
            CheckStatus.Name = "CheckStatus";
            CheckStatus.Size = new Size(75, 21);
            CheckStatus.TabIndex = 5;
            CheckStatus.Text = "Status:";
            CheckStatus.UseVisualStyleBackColor = true;
            CheckStatus.CheckedChanged += CheckStatus_CheckedChanged;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(64, 64, 64);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Enabled = false;
            txtName.ForeColor = Color.Lime;
            txtName.Location = new Point(106, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(128, 27);
            txtName.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Lime;
            btnBack.Location = new Point(919, 45);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(56, 26);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.Lime;
            btnNext.Location = new Point(988, 45);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(56, 26);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.BackColor = Color.Transparent;
            btnVolverMenu.FlatStyle = FlatStyle.Flat;
            btnVolverMenu.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverMenu.ForeColor = Color.Lime;
            btnVolverMenu.Location = new Point(932, 658);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(118, 28);
            btnVolverMenu.TabIndex = 8;
            btnVolverMenu.Text = "Volver al menu";
            btnVolverMenu.UseVisualStyleBackColor = false;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // PagesCharacters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            BackgroundImage = Properties.Resources.ImageBack;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 698);
            ControlBox = false;
            Controls.Add(btnVolverMenu);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(PanelDeImages);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PagesCharacters";
            StartPosition = FormStartPosition.CenterScreen;
            Load += PagesCharacters_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel PanelDeImages;
        private GroupBox groupBox1;
        private TextBox txtName;
        private Button btnFiltrar;
        private CheckBox CheckStatus;
        private Button btnBack;
        private Button btnNext;
        private Button btnQuitarFiltros;
        private ComboBox ComboStatus;
        private ComboBox ComboGender;
        private CheckBox CheckGender;
        private CheckBox CheckName;
        private Button btnVolverMenu;
    }
}