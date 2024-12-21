namespace MinunOhjelmani
{
    partial class MinunOhjelmaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TervetuloaLB = new Label();
            AloitaBT = new Button();
            SuspendLayout();
            // 
            // TervetuloaLB
            // 
            TervetuloaLB.AutoSize = true;
            TervetuloaLB.BackColor = SystemColors.Window;
            TervetuloaLB.Font = new Font("Lucida Calligraphy", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TervetuloaLB.Location = new Point(195, 173);
            TervetuloaLB.Name = "TervetuloaLB";
            TervetuloaLB.Size = new Size(435, 83);
            TervetuloaLB.TabIndex = 0;
            TervetuloaLB.Text = "Tervetuloa!";
            // 
            // AloitaBT
            // 
            AloitaBT.BackColor = SystemColors.InactiveCaption;
            AloitaBT.Font = new Font("Lucida Calligraphy", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AloitaBT.ForeColor = SystemColors.InactiveCaptionText;
            AloitaBT.Location = new Point(344, 294);
            AloitaBT.Name = "AloitaBT";
            AloitaBT.Size = new Size(154, 49);
            AloitaBT.TabIndex = 1;
            AloitaBT.Text = "Aloita";
            AloitaBT.UseVisualStyleBackColor = false;
            AloitaBT.Click += AloitaBT_Click;
            // 
            // MinunOhjelmaForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.luxurious_floral_wedding_frame_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(836, 500);
            Controls.Add(AloitaBT);
            Controls.Add(TervetuloaLB);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "MinunOhjelmaForm";
            Text = "Minun Ohjelmani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TervetuloaLB;
        private Button AloitaBT;
    }
}
