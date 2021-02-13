namespace Minesweeper_19001
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.radioHard = new System.Windows.Forms.RadioButton();
            this.radioIntermediate = new System.Windows.Forms.RadioButton();
            this.radioBeginner = new System.Windows.Forms.RadioButton();
            this.gamePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeScreen = new System.Windows.Forms.Label();
            this.StartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.timeScreen);
            this.StartPanel.Controls.Add(this.StartButton);
            this.StartPanel.Controls.Add(this.radioHard);
            this.StartPanel.Controls.Add(this.radioIntermediate);
            this.StartPanel.Controls.Add(this.radioBeginner);
            this.StartPanel.Location = new System.Drawing.Point(10, 5);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(600, 30);
            this.StartPanel.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartButton.Location = new System.Drawing.Point(266, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(123, 24);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // radioHard
            // 
            this.radioHard.AutoSize = true;
            this.radioHard.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHard.Location = new System.Drawing.Point(201, 3);
            this.radioHard.Name = "radioHard";
            this.radioHard.Size = new System.Drawing.Size(59, 24);
            this.radioHard.TabIndex = 2;
            this.radioHard.Text = "Hard";
            this.radioHard.UseVisualStyleBackColor = true;
            // 
            // radioIntermediate
            // 
            this.radioIntermediate.AutoSize = true;
            this.radioIntermediate.Checked = true;
            this.radioIntermediate.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIntermediate.Location = new System.Drawing.Point(91, 3);
            this.radioIntermediate.Name = "radioIntermediate";
            this.radioIntermediate.Size = new System.Drawing.Size(104, 24);
            this.radioIntermediate.TabIndex = 1;
            this.radioIntermediate.TabStop = true;
            this.radioIntermediate.Text = "Intermediate";
            this.radioIntermediate.UseVisualStyleBackColor = true;
            // 
            // radioBeginner
            // 
            this.radioBeginner.AutoSize = true;
            this.radioBeginner.Font = new System.Drawing.Font("Goudy Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBeginner.Location = new System.Drawing.Point(3, 3);
            this.radioBeginner.Name = "radioBeginner";
            this.radioBeginner.Size = new System.Drawing.Size(82, 24);
            this.radioBeginner.TabIndex = 0;
            this.radioBeginner.Text = "Beginner";
            this.radioBeginner.UseVisualStyleBackColor = true;
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(10, 41);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(600, 600);
            this.gamePanel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeScreen
            // 
            this.timeScreen.AutoSize = true;
            this.timeScreen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeScreen.Location = new System.Drawing.Point(500, 5);
            this.timeScreen.Name = "timeScreen";
            this.timeScreen.Size = new System.Drawing.Size(0, 18);
            this.timeScreen.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(624, 646);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.StartPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MINESWEEPER";
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RadioButton radioHard;
        private System.Windows.Forms.RadioButton radioIntermediate;
        private System.Windows.Forms.RadioButton radioBeginner;
        private System.Windows.Forms.FlowLayoutPanel gamePanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeScreen;
    }
}

