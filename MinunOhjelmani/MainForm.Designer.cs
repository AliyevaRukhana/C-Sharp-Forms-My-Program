namespace MinunOhjelmani
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            Aika = new DataGridViewTextBoxColumn();
            Maanantai = new DataGridViewTextBoxColumn();
            Tiistai = new DataGridViewTextBoxColumn();
            Keskiviikko = new DataGridViewTextBoxColumn();
            Torstai = new DataGridViewTextBoxColumn();
            Perjantai = new DataGridViewTextBoxColumn();
            Lauantai = new DataGridViewTextBoxColumn();
            Sunnuntai = new DataGridViewTextBoxColumn();
            TallennaBT = new Button();
            AvaaBT = new Button();
            PoistaBT = new Button();
            monthCalendar1 = new MonthCalendar();
            AikaLB = new Label();
            Ajastin = new System.Windows.Forms.Timer(components);
            PoistuBT = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Aika, Maanantai, Tiistai, Keskiviikko, Torstai, Perjantai, Lauantai, Sunnuntai });
            dataGridView1.GridColor = SystemColors.InactiveCaption;
            dataGridView1.Location = new Point(-1, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(801, 507);
            dataGridView1.TabIndex = 0;
            // 
            // Aika
            // 
            Aika.Frozen = true;
            Aika.HeaderText = "Aika";
            Aika.Name = "Aika";
            Aika.ReadOnly = true;
            Aika.Width = 55;
            // 
            // Maanantai
            // 
            Maanantai.Frozen = true;
            Maanantai.HeaderText = "Maanantai";
            Maanantai.Name = "Maanantai";
            Maanantai.Width = 95;
            // 
            // Tiistai
            // 
            Tiistai.Frozen = true;
            Tiistai.HeaderText = "Tiistai";
            Tiistai.Name = "Tiistai";
            Tiistai.Width = 95;
            // 
            // Keskiviikko
            // 
            Keskiviikko.Frozen = true;
            Keskiviikko.HeaderText = "Keskiviikko";
            Keskiviikko.Name = "Keskiviikko";
            Keskiviikko.Width = 95;
            // 
            // Torstai
            // 
            Torstai.Frozen = true;
            Torstai.HeaderText = "Torstai";
            Torstai.Name = "Torstai";
            Torstai.Width = 95;
            // 
            // Perjantai
            // 
            Perjantai.Frozen = true;
            Perjantai.HeaderText = "Perjantai";
            Perjantai.Name = "Perjantai";
            Perjantai.Width = 95;
            // 
            // Lauantai
            // 
            Lauantai.Frozen = true;
            Lauantai.HeaderText = "Lauantai";
            Lauantai.Name = "Lauantai";
            Lauantai.Width = 95;
            // 
            // Sunnuntai
            // 
            Sunnuntai.Frozen = true;
            Sunnuntai.HeaderText = "Sunnuntai";
            Sunnuntai.Name = "Sunnuntai";
            Sunnuntai.Width = 95;
            // 
            // TallennaBT
            // 
            TallennaBT.Font = new Font("Lucida Bright", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TallennaBT.ForeColor = SystemColors.MenuHighlight;
            TallennaBT.Location = new Point(820, 40);
            TallennaBT.Name = "TallennaBT";
            TallennaBT.Size = new Size(167, 46);
            TallennaBT.TabIndex = 1;
            TallennaBT.Text = "Tallenna";
            TallennaBT.UseVisualStyleBackColor = true;
            TallennaBT.Click += TallennaBT_Click;
            // 
            // AvaaBT
            // 
            AvaaBT.Font = new Font("Lucida Bright", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AvaaBT.ForeColor = SystemColors.MenuHighlight;
            AvaaBT.Location = new Point(820, 92);
            AvaaBT.Name = "AvaaBT";
            AvaaBT.Size = new Size(167, 46);
            AvaaBT.TabIndex = 2;
            AvaaBT.Text = "Avaa";
            AvaaBT.UseVisualStyleBackColor = true;
            AvaaBT.Click += AvaaBT_Click;
            // 
            // PoistaBT
            // 
            PoistaBT.Font = new Font("Lucida Bright", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PoistaBT.ForeColor = SystemColors.MenuHighlight;
            PoistaBT.Location = new Point(820, 144);
            PoistaBT.Name = "PoistaBT";
            PoistaBT.Size = new Size(167, 45);
            PoistaBT.TabIndex = 3;
            PoistaBT.Text = "Poista";
            PoistaBT.UseVisualStyleBackColor = true;
            PoistaBT.Click += PoistaBT_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(813, 257);
            monthCalendar1.Margin = new Padding(10, 9, 10, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // AikaLB
            // 
            AikaLB.BackColor = Color.White;
            AikaLB.Font = new Font("Lucida Bright", 17F, FontStyle.Bold);
            AikaLB.Location = new Point(845, 211);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(117, 28);
            AikaLB.TabIndex = 5;
            AikaLB.Text = "00:00:00";
            // 
            // Ajastin
            // 
            Ajastin.Enabled = true;
            Ajastin.Interval = 1000;
            Ajastin.Tick += Ajastin_Tick;
            // 
            // PoistuBT
            // 
            PoistuBT.BackColor = SystemColors.InactiveCaption;
            PoistuBT.BackgroundImage = Properties.Resources.button_2025915_1280;
            PoistuBT.BackgroundImageLayout = ImageLayout.Zoom;
            PoistuBT.Location = new Point(813, 462);
            PoistuBT.Name = "PoistuBT";
            PoistuBT.Size = new Size(37, 33);
            PoistuBT.TabIndex = 6;
            PoistuBT.UseVisualStyleBackColor = false;
            PoistuBT.Click += PoistuBT_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.luxurious_floral_wedding_frame_design;
            ClientSize = new Size(999, 507);
            Controls.Add(PoistuBT);
            Controls.Add(AikaLB);
            Controls.Add(monthCalendar1);
            Controls.Add(PoistaBT);
            Controls.Add(AvaaBT);
            Controls.Add(TallennaBT);
            Controls.Add(dataGridView1);
            Font = new Font("Lucida Bright", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "Aikataulu";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button TallennaBT;
        private Button AvaaBT;
        private Button PoistaBT;
        private MonthCalendar monthCalendar1;
        private DataGridViewTextBoxColumn Aika;
        private DataGridViewTextBoxColumn Maanantai;
        private DataGridViewTextBoxColumn Tiistai;
        private DataGridViewTextBoxColumn Keskiviikko;
        private DataGridViewTextBoxColumn Torstai;
        private DataGridViewTextBoxColumn Perjantai;
        private DataGridViewTextBoxColumn Lauantai;
        private DataGridViewTextBoxColumn Sunnuntai;
        private Label AikaLB;
        private System.Windows.Forms.Timer Ajastin;
        private Button PoistuBT;
    }
}