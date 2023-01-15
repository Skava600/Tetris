namespace TetrisGame
{
    partial class Options
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
            this.saveButton = new FontAwesome.Sharp.IconButton();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.heightTrackBar = new System.Windows.Forms.TrackBar();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthTrackBar = new System.Windows.Forms.TrackBar();
            this.heightValueLabel = new System.Windows.Forms.Label();
            this.widthValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.saveButton.IconColor = System.Drawing.Color.Black;
            this.saveButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.saveButton.IconSize = 32;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(109, 280);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.saveButton.Size = new System.Drawing.Size(171, 60);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.closeButton.IconColor = System.Drawing.Color.Black;
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.closeButton.IconSize = 32;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Location = new System.Drawing.Point(109, 357);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.closeButton.Size = new System.Drawing.Size(171, 60);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // heightTrackBar
            // 
            this.heightTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightTrackBar.Cursor = System.Windows.Forms.Cursors.No;
            this.heightTrackBar.Location = new System.Drawing.Point(83, 22);
            this.heightTrackBar.Maximum = 40;
            this.heightTrackBar.Minimum = 20;
            this.heightTrackBar.Name = "heightTrackBar";
            this.heightTrackBar.Size = new System.Drawing.Size(261, 56);
            this.heightTrackBar.TabIndex = 3;
            this.heightTrackBar.Value = 20;
            this.heightTrackBar.ValueChanged += new System.EventHandler(this.heightTrackBar_ValueChanged);
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heightLabel.Location = new System.Drawing.Point(12, 22);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(65, 21);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.widthLabel.Location = new System.Drawing.Point(12, 86);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(60, 21);
            this.widthLabel.TabIndex = 5;
            this.widthLabel.Text = "Width";
            // 
            // widthTrackBar
            // 
            this.widthTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthTrackBar.Location = new System.Drawing.Point(83, 86);
            this.widthTrackBar.Maximum = 30;
            this.widthTrackBar.Minimum = 15;
            this.widthTrackBar.Name = "widthTrackBar";
            this.widthTrackBar.Size = new System.Drawing.Size(261, 56);
            this.widthTrackBar.TabIndex = 6;
            this.widthTrackBar.Value = 15;
            this.widthTrackBar.ValueChanged += new System.EventHandler(this.widthTrackBar_ValueChanged);
            // 
            // heightValueLabel
            // 
            this.heightValueLabel.AutoSize = true;
            this.heightValueLabel.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heightValueLabel.Location = new System.Drawing.Point(348, 23);
            this.heightValueLabel.Name = "heightValueLabel";
            this.heightValueLabel.Size = new System.Drawing.Size(31, 21);
            this.heightValueLabel.TabIndex = 7;
            this.heightValueLabel.Text = "20";
            // 
            // widthValueLabel
            // 
            this.widthValueLabel.AutoSize = true;
            this.widthValueLabel.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.widthValueLabel.Location = new System.Drawing.Point(348, 86);
            this.widthValueLabel.Name = "widthValueLabel";
            this.widthValueLabel.Size = new System.Drawing.Size(28, 21);
            this.widthValueLabel.TabIndex = 8;
            this.widthValueLabel.Text = "15";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.widthValueLabel);
            this.Controls.Add(this.heightValueLabel);
            this.Controls.Add(this.widthTrackBar);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.heightTrackBar);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton saveButton;
        private FontAwesome.Sharp.IconButton closeButton;
        private TrackBar heightTrackBar;
        private Label heightLabel;
        private Label widthLabel;
        private TrackBar widthTrackBar;
        private Label heightValueLabel;
        private Label widthValueLabel;
    }
}