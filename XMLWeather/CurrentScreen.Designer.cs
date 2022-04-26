namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.slashLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cityOutput.ForeColor = System.Drawing.Color.DarkGray;
            this.cityOutput.Location = new System.Drawing.Point(20, 14);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(198, 57);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "cityOutput";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(658, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.forecastLabel.Location = new System.Drawing.Point(658, 60);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // tempLabel
            // 
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.tempLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.tempLabel.Location = new System.Drawing.Point(263, 131);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(260, 97);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maxLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.maxLabel.Location = new System.Drawing.Point(417, 257);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(33, 17);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.minLabel.Location = new System.Drawing.Point(343, 257);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(30, 17);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slashLabel
            // 
            this.slashLabel.BackColor = System.Drawing.Color.Transparent;
            this.slashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.slashLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.slashLabel.Location = new System.Drawing.Point(374, 245);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(33, 38);
            this.slashLabel.TabIndex = 42;
            this.slashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.conditionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.conditionLabel.Location = new System.Drawing.Point(30, 350);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(152, 26);
            this.conditionLabel.TabIndex = 43;
            this.conditionLabel.Text = "conditionLabel";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(658, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Search";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(58, 131);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(139, 130);
            this.pictureBox6.TabIndex = 44;
            this.pictureBox6.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.slashLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.tempLabel);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(765, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label slashLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
