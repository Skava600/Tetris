namespace TetrisGame
{
    partial class NewFigure
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
            this.saveBlockButton = new FontAwesome.Sharp.IconButton();
            this.cancelSavingButton = new FontAwesome.Sharp.IconButton();
            this.figureTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.figureNameTextBox = new System.Windows.Forms.TextBox();
            this.figureNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBlockButton
            // 
            this.saveBlockButton.BackColor = System.Drawing.Color.Snow;
            this.saveBlockButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBlockButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.saveBlockButton.IconColor = System.Drawing.Color.ForestGreen;
            this.saveBlockButton.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.saveBlockButton.Location = new System.Drawing.Point(271, 372);
            this.saveBlockButton.Name = "saveBlockButton";
            this.saveBlockButton.Size = new System.Drawing.Size(50, 50);
            this.saveBlockButton.TabIndex = 0;
            this.saveBlockButton.UseVisualStyleBackColor = false;
            this.saveBlockButton.Click += new System.EventHandler(this.saveBlockButton_Click);
            // 
            // cancelSavingButton
            // 
            this.cancelSavingButton.BackColor = System.Drawing.Color.Snow;
            this.cancelSavingButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelSavingButton.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.cancelSavingButton.IconColor = System.Drawing.Color.Red;
            this.cancelSavingButton.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.cancelSavingButton.Location = new System.Drawing.Point(215, 372);
            this.cancelSavingButton.Name = "cancelSavingButton";
            this.cancelSavingButton.Size = new System.Drawing.Size(50, 50);
            this.cancelSavingButton.TabIndex = 1;
            this.cancelSavingButton.UseVisualStyleBackColor = false;
            this.cancelSavingButton.Click += new System.EventHandler(this.cancelSavingButton_Click);
            // 
            // figureTableLayoutPanel
            // 
            this.figureTableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.figureTableLayoutPanel.ColumnCount = 4;
            this.figureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.figureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.figureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.figureTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.figureTableLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.figureTableLayoutPanel.Location = new System.Drawing.Point(31, 28);
            this.figureTableLayoutPanel.Name = "figureTableLayoutPanel";
            this.figureTableLayoutPanel.RowCount = 4;
            this.figureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.figureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.figureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.figureTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.figureTableLayoutPanel.Size = new System.Drawing.Size(320, 269);
            this.figureTableLayoutPanel.TabIndex = 2;
            // 
            // figureNameTextBox
            // 
            this.figureNameTextBox.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.figureNameTextBox.Location = new System.Drawing.Point(177, 316);
            this.figureNameTextBox.Name = "figureNameTextBox";
            this.figureNameTextBox.Size = new System.Drawing.Size(174, 38);
            this.figureNameTextBox.TabIndex = 3;
            // 
            // figureNameLabel
            // 
            this.figureNameLabel.AutoSize = true;
            this.figureNameLabel.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.figureNameLabel.Location = new System.Drawing.Point(31, 323);
            this.figureNameLabel.Name = "figureNameLabel";
            this.figureNameLabel.Size = new System.Drawing.Size(145, 27);
            this.figureNameLabel.TabIndex = 4;
            this.figureNameLabel.Text = "Figure Name";
            // 
            // NewFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(390, 479);
            this.Controls.Add(this.figureNameLabel);
            this.Controls.Add(this.figureNameTextBox);
            this.Controls.Add(this.figureTableLayoutPanel);
            this.Controls.Add(this.cancelSavingButton);
            this.Controls.Add(this.saveBlockButton);
            this.MaximumSize = new System.Drawing.Size(408, 526);
            this.MinimumSize = new System.Drawing.Size(408, 526);
            this.Name = "NewFigure";
            this.Text = "NewBlock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton saveBlockButton;
        private FontAwesome.Sharp.IconButton cancelSavingButton;
        private TableLayoutPanel figureTableLayoutPanel;
        private TextBox figureNameTextBox;
        private Label figureNameLabel;
    }
}