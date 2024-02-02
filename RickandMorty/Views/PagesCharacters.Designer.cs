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
            PanelDeImages = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            ComboStatus = new ComboBox();
            CheckTodos = new CheckBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            btnFiltrar = new Button();
            btnBack = new Button();
            btnNext = new Button();
            btnQuitarFiltros = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelDeImages
            // 
            PanelDeImages.Location = new Point(12, 80);
            PanelDeImages.Name = "PanelDeImages";
            PanelDeImages.Size = new Size(1037, 555);
            PanelDeImages.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComboStatus);
            groupBox1.Controls.Add(CheckTodos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(625, 62);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // ComboStatus
            // 
            ComboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboStatus.FormattingEnabled = true;
            ComboStatus.Items.AddRange(new object[] { "alive", "dead", "unknown" });
            ComboStatus.Location = new Point(270, 25);
            ComboStatus.Name = "ComboStatus";
            ComboStatus.Size = new Size(121, 23);
            ComboStatus.TabIndex = 6;
            // 
            // CheckTodos
            // 
            CheckTodos.AutoSize = true;
            CheckTodos.Checked = true;
            CheckTodos.CheckState = CheckState.Checked;
            CheckTodos.Location = new Point(397, 28);
            CheckTodos.Name = "CheckTodos";
            CheckTodos.Size = new Size(57, 19);
            CheckTodos.TabIndex = 5;
            CheckTodos.Text = "Todos";
            CheckTodos.UseVisualStyleBackColor = true;
            CheckTodos.CheckedChanged += CheckTodos_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 28);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Status:";
            // 
            // txtName
            // 
            txtName.Location = new Point(76, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(128, 23);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(533, 33);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(86, 23);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Aplicar filtros";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(919, 45);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(56, 23);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(988, 45);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(56, 23);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnQuitarFiltros
            // 
            btnQuitarFiltros.Location = new Point(643, 45);
            btnQuitarFiltros.Name = "btnQuitarFiltros";
            btnQuitarFiltros.Size = new Size(86, 23);
            btnQuitarFiltros.TabIndex = 6;
            btnQuitarFiltros.Text = "Quitar filtros";
            btnQuitarFiltros.UseVisualStyleBackColor = true;
            btnQuitarFiltros.Click += btnQuitarFiltros_Click;
            // 
            // PagesCharacters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 647);
            Controls.Add(btnQuitarFiltros);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(PanelDeImages);
            Name = "PagesCharacters";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PagesCharacters";
            Load += PagesCharacters_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel PanelDeImages;
        private GroupBox groupBox1;
        private TextBox txtName;
        private Label label1;
        private Button btnFiltrar;
        private Label label2;
        private CheckBox CheckTodos;
        private Button btnBack;
        private Button btnNext;
        private Button btnQuitarFiltros;
        private ComboBox ComboStatus;
    }
}