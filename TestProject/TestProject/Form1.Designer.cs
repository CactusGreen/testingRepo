namespace TestProject
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
            this.Go = new System.Windows.Forms.Button();
            this.longitudeBox = new System.Windows.Forms.TextBox();
            this.longitudeLabel = new System.Windows.Forms.Label();
            this.latitudeBox = new System.Windows.Forms.TextBox();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.latitudeLabel = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(222, 116);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 0;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // longitudeBox
            // 
            this.longitudeBox.Location = new System.Drawing.Point(137, 12);
            this.longitudeBox.Name = "longitudeBox";
            this.longitudeBox.Size = new System.Drawing.Size(100, 20);
            this.longitudeBox.TabIndex = 1;
            // 
            // longitudeLabel
            // 
            this.longitudeLabel.AutoSize = true;
            this.longitudeLabel.Location = new System.Drawing.Point(63, 15);
            this.longitudeLabel.Name = "longitudeLabel";
            this.longitudeLabel.Size = new System.Drawing.Size(54, 13);
            this.longitudeLabel.TabIndex = 2;
            this.longitudeLabel.Text = "Longitude";
            this.longitudeLabel.Click += new System.EventHandler(this.longitudeLabel_Click);
            // 
            // latitudeBox
            // 
            this.latitudeBox.Location = new System.Drawing.Point(137, 39);
            this.latitudeBox.Name = "latitudeBox";
            this.latitudeBox.Size = new System.Drawing.Size(100, 20);
            this.latitudeBox.TabIndex = 3;
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(137, 65);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusTextBox.TabIndex = 4;
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Location = new System.Drawing.Point(63, 39);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(45, 13);
            this.latitudeLabel.TabIndex = 5;
            this.latitudeLabel.Text = "Latitude";
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(63, 65);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(40, 13);
            this.radiusLabel.TabIndex = 6;
            this.radiusLabel.Text = "Radius";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(455, 12);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(288, 515);
            this.resultTextBox.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 539);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.latitudeLabel);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.latitudeBox);
            this.Controls.Add(this.longitudeLabel);
            this.Controls.Add(this.longitudeBox);
            this.Controls.Add(this.Go);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox longitudeBox;
        private System.Windows.Forms.Label longitudeLabel;
        private System.Windows.Forms.TextBox latitudeBox;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Label latitudeLabel;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

