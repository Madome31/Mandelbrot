namespace Mandelbrot_Fractal_SingleZoom
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.fractalBox = new System.Windows.Forms.PictureBox();
            this.calculateStartImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resulutionBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datatypeBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fractalBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fractalBox
            // 
            this.fractalBox.Location = new System.Drawing.Point(12, 12);
            this.fractalBox.Name = "fractalBox";
            this.fractalBox.Size = new System.Drawing.Size(884, 600);
            this.fractalBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fractalBox.TabIndex = 0;
            this.fractalBox.TabStop = false;
            // 
            // calculateStartImage
            // 
            this.calculateStartImage.Location = new System.Drawing.Point(902, 12);
            this.calculateStartImage.Name = "calculateStartImage";
            this.calculateStartImage.Size = new System.Drawing.Size(153, 23);
            this.calculateStartImage.TabIndex = 1;
            this.calculateStartImage.Text = "Startbild";
            this.calculateStartImage.UseVisualStyleBackColor = true;
            this.calculateStartImage.Click += new System.EventHandler(this.calculateStartImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Auflösung";
            // 
            // resulutionBox
            // 
            this.resulutionBox.FormattingEnabled = true;
            this.resulutionBox.Items.AddRange(new object[] {
            "HD",
            "FullHD",
            "4k",
            "8k",
            "16k"});
            this.resulutionBox.Location = new System.Drawing.Point(902, 83);
            this.resulutionBox.Name = "resulutionBox";
            this.resulutionBox.Size = new System.Drawing.Size(121, 21);
            this.resulutionBox.TabIndex = 5;
            this.resulutionBox.Text = "FullHD";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(905, 589);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(150, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Speichern";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(902, 107);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(29, 13);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "0 ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(899, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datatype";
            // 
            // datatypeBox
            // 
            this.datatypeBox.FormattingEnabled = true;
            this.datatypeBox.Items.AddRange(new object[] {
            "Float",
            "Double",
            "Decimal",
            "SqlDecimal"});
            this.datatypeBox.Location = new System.Drawing.Point(902, 136);
            this.datatypeBox.Name = "datatypeBox";
            this.datatypeBox.Size = new System.Drawing.Size(121, 21);
            this.datatypeBox.TabIndex = 9;
            this.datatypeBox.Text = "Double";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1067, 624);
            this.Controls.Add(this.datatypeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resulutionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateStartImage);
            this.Controls.Add(this.fractalBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fractalBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fractalBox;
        private System.Windows.Forms.Button calculateStartImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox resulutionBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox datatypeBox;
    }
}

