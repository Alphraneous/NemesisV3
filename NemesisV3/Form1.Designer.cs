namespace NemesisV3
{
    partial class Nemesis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nemesis));
            this.scriptBox = new System.Windows.Forms.RichTextBox();
            this.injectButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wkSpdBox = new System.Windows.Forms.TextBox();
            this.jmpPwrBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.execute2Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flyButton = new System.Windows.Forms.Button();
            this.infJumpButton = new System.Windows.Forms.Button();
            this.scriptList = new System.Windows.Forms.ListBox();
            this.killButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scriptBox
            // 
            this.scriptBox.Location = new System.Drawing.Point(12, 43);
            this.scriptBox.Name = "scriptBox";
            this.scriptBox.Size = new System.Drawing.Size(415, 286);
            this.scriptBox.TabIndex = 0;
            this.scriptBox.Text = "";
            // 
            // injectButton
            // 
            this.injectButton.Location = new System.Drawing.Point(13, 13);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(75, 23);
            this.injectButton.TabIndex = 1;
            this.injectButton.Text = "Inject";
            this.injectButton.UseVisualStyleBackColor = true;
            this.injectButton.Click += new System.EventHandler(this.injectButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(12, 336);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(99, 37);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(118, 336);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 37);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(451, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Walk Speed";
            // 
            // wkSpdBox
            // 
            this.wkSpdBox.Location = new System.Drawing.Point(433, 68);
            this.wkSpdBox.Name = "wkSpdBox";
            this.wkSpdBox.Size = new System.Drawing.Size(100, 20);
            this.wkSpdBox.TabIndex = 5;
            this.wkSpdBox.Text = "60";
            // 
            // jmpPwrBox
            // 
            this.jmpPwrBox.Location = new System.Drawing.Point(433, 126);
            this.jmpPwrBox.Name = "jmpPwrBox";
            this.jmpPwrBox.Size = new System.Drawing.Size(100, 20);
            this.jmpPwrBox.TabIndex = 7;
            this.jmpPwrBox.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(451, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jump Power";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(433, 162);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(99, 37);
            this.applyBtn.TabIndex = 8;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // execute2Btn
            // 
            this.execute2Btn.Location = new System.Drawing.Point(539, 336);
            this.execute2Btn.Name = "execute2Btn";
            this.execute2Btn.Size = new System.Drawing.Size(121, 37);
            this.execute2Btn.TabIndex = 10;
            this.execute2Btn.Text = "Execute";
            this.execute2Btn.UseVisualStyleBackColor = true;
            this.execute2Btn.Click += new System.EventHandler(this.execute2Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(572, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Script Hub";
            // 
            // flyButton
            // 
            this.flyButton.Location = new System.Drawing.Point(434, 218);
            this.flyButton.Name = "flyButton";
            this.flyButton.Size = new System.Drawing.Size(99, 22);
            this.flyButton.TabIndex = 12;
            this.flyButton.Text = "Fly";
            this.flyButton.UseVisualStyleBackColor = true;
            this.flyButton.Click += new System.EventHandler(this.flyButton_Click);
            // 
            // infJumpButton
            // 
            this.infJumpButton.Location = new System.Drawing.Point(433, 246);
            this.infJumpButton.Name = "infJumpButton";
            this.infJumpButton.Size = new System.Drawing.Size(99, 22);
            this.infJumpButton.TabIndex = 13;
            this.infJumpButton.Text = "Infinite Jump";
            this.infJumpButton.UseVisualStyleBackColor = true;
            this.infJumpButton.Click += new System.EventHandler(this.infJumpButton_Click);
            // 
            // scriptList
            // 
            this.scriptList.FormattingEnabled = true;
            this.scriptList.Items.AddRange(new object[] {
            "PF Hub",
            "Apathy (Eclipsis)",
            "Jailbreak GUI",
            "Welcome to Bloxburg",
            "Jailbreak GUI 2",
            "Arsenal"});
            this.scriptList.Location = new System.Drawing.Point(540, 39);
            this.scriptList.Name = "scriptList";
            this.scriptList.Size = new System.Drawing.Size(120, 290);
            this.scriptList.TabIndex = 14;
            // 
            // killButton
            // 
            this.killButton.Location = new System.Drawing.Point(328, 335);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(99, 37);
            this.killButton.TabIndex = 15;
            this.killButton.Text = "Kill Roblox";
            this.killButton.UseVisualStyleBackColor = true;
            this.killButton.Click += new System.EventHandler(this.killButton_Click);
            // 
            // Nemesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 385);
            this.Controls.Add(this.killButton);
            this.Controls.Add(this.scriptList);
            this.Controls.Add(this.infJumpButton);
            this.Controls.Add(this.flyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.execute2Btn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.jmpPwrBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wkSpdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.injectButton);
            this.Controls.Add(this.scriptBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Nemesis";
            this.Text = "Nemesis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox scriptBox;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wkSpdBox;
        private System.Windows.Forms.TextBox jmpPwrBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button execute2Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button flyButton;
        private System.Windows.Forms.Button infJumpButton;
        private System.Windows.Forms.ListBox scriptList;
        private System.Windows.Forms.Button killButton;
    }
}

