namespace TetrisGame
{
    partial class MainMenu
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
            this.playButton = new FontAwesome.Sharp.IconButton();
            this.newFigureButton = new FontAwesome.Sharp.IconButton();
            this.tetrisHeaderLabel = new System.Windows.Forms.Label();
            this.optionsButton = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.playButton.IconColor = System.Drawing.Color.Black;
            this.playButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.playButton.IconSize = 32;
            this.playButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playButton.Location = new System.Drawing.Point(151, 284);
            this.playButton.Name = "playButton";
            this.playButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.playButton.Size = new System.Drawing.Size(171, 60);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newFigureButton
            // 
            this.newFigureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newFigureButton.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newFigureButton.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.newFigureButton.IconColor = System.Drawing.Color.Black;
            this.newFigureButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.newFigureButton.IconSize = 32;
            this.newFigureButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newFigureButton.Location = new System.Drawing.Point(151, 373);
            this.newFigureButton.Name = "newFigureButton";
            this.newFigureButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.newFigureButton.Size = new System.Drawing.Size(171, 60);
            this.newFigureButton.TabIndex = 1;
            this.newFigureButton.Text = "New Figure";
            this.newFigureButton.UseVisualStyleBackColor = true;
            this.newFigureButton.Click += new System.EventHandler(this.newFigureButton_Click);
            // 
            // tetrisHeaderLabel
            // 
            this.tetrisHeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tetrisHeaderLabel.AutoSize = true;
            this.tetrisHeaderLabel.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tetrisHeaderLabel.Location = new System.Drawing.Point(176, 27);
            this.tetrisHeaderLabel.Name = "tetrisHeaderLabel";
            this.tetrisHeaderLabel.Size = new System.Drawing.Size(115, 43);
            this.tetrisHeaderLabel.TabIndex = 2;
            this.tetrisHeaderLabel.Text = "Tetris";
            this.tetrisHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsButton
            // 
            this.optionsButton.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optionsButton.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.optionsButton.IconColor = System.Drawing.Color.Black;
            this.optionsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.optionsButton.IconSize = 32;
            this.optionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionsButton.Location = new System.Drawing.Point(151, 468);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.optionsButton.Size = new System.Drawing.Size(171, 60);
            this.optionsButton.TabIndex = 3;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.exitButton.IconColor = System.Drawing.Color.Black;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 32;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(151, 562);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.exitButton.Size = new System.Drawing.Size(171, 60);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(481, 653);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.tetrisHeaderLabel);
            this.Controls.Add(this.newFigureButton);
            this.Controls.Add(this.playButton);
            this.MaximumSize = new System.Drawing.Size(499, 700);
            this.MinimumSize = new System.Drawing.Size(499, 700);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton playButton;
        private FontAwesome.Sharp.IconButton newFigureButton;
        private Label tetrisHeaderLabel;
        private FontAwesome.Sharp.IconButton optionsButton;
        private FontAwesome.Sharp.IconButton exitButton;
    }
}