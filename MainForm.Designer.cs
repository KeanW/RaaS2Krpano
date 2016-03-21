namespace RaaS2Krpano
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
      this.ProcessButton = new System.Windows.Forms.Button();
      this.logText = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.welcomeBox = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.url7 = new System.Windows.Forms.TextBox();
      this.name7 = new System.Windows.Forms.TextBox();
      this.url6 = new System.Windows.Forms.TextBox();
      this.name6 = new System.Windows.Forms.TextBox();
      this.name5 = new System.Windows.Forms.TextBox();
      this.name4 = new System.Windows.Forms.TextBox();
      this.name3 = new System.Windows.Forms.TextBox();
      this.name2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.name1 = new System.Windows.Forms.TextBox();
      this.url5 = new System.Windows.Forms.TextBox();
      this.url4 = new System.Windows.Forms.TextBox();
      this.url3 = new System.Windows.Forms.TextBox();
      this.url2 = new System.Windows.Forms.TextBox();
      this.url1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.thumbnailAngle = new System.Windows.Forms.NumericUpDown();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.thumbnailAngle)).BeginInit();
      this.SuspendLayout();
      // 
      // ProcessButton
      // 
      this.ProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.ProcessButton.Location = new System.Drawing.Point(13, 470);
      this.ProcessButton.Name = "ProcessButton";
      this.ProcessButton.Size = new System.Drawing.Size(75, 23);
      this.ProcessButton.TabIndex = 20;
      this.ProcessButton.Text = "Process";
      this.ProcessButton.UseVisualStyleBackColor = true;
      this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
      // 
      // logText
      // 
      this.logText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.logText.BackColor = System.Drawing.SystemColors.Control;
      this.logText.Location = new System.Drawing.Point(16, 338);
      this.logText.Multiline = true;
      this.logText.Name = "logText";
      this.logText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.logText.Size = new System.Drawing.Size(610, 116);
      this.logText.TabIndex = 19;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 13);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Welcome text";
      // 
      // welcomeBox
      // 
      this.welcomeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.welcomeBox.Location = new System.Drawing.Point(134, 10);
      this.welcomeBox.Name = "welcomeBox";
      this.welcomeBox.Size = new System.Drawing.Size(497, 20);
      this.welcomeBox.TabIndex = 2;
      this.welcomeBox.Text = "Scenes from A360 Cloud Rendering";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.url7);
      this.groupBox1.Controls.Add(this.name7);
      this.groupBox1.Controls.Add(this.url6);
      this.groupBox1.Controls.Add(this.name6);
      this.groupBox1.Controls.Add(this.name5);
      this.groupBox1.Controls.Add(this.name4);
      this.groupBox1.Controls.Add(this.name3);
      this.groupBox1.Controls.Add(this.name2);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.name1);
      this.groupBox1.Controls.Add(this.url5);
      this.groupBox1.Controls.Add(this.url4);
      this.groupBox1.Controls.Add(this.url3);
      this.groupBox1.Controls.Add(this.url2);
      this.groupBox1.Controls.Add(this.url1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 60);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(619, 227);
      this.groupBox1.TabIndex = 15;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Pano names and RaaS URLs";
      // 
      // url7
      // 
      this.url7.Location = new System.Drawing.Point(130, 191);
      this.url7.Name = "url7";
      this.url7.Size = new System.Drawing.Size(469, 20);
      this.url7.TabIndex = 16;
      this.url7.Text = "https://d1zjbwmh9kbk11.cloudfront.net/a360-rendering/panorama/pano.html?url=16012" +
    "5/8412/8f94ad0f";
      // 
      // name7
      // 
      this.name7.Location = new System.Drawing.Point(24, 191);
      this.name7.Name = "name7";
      this.name7.Size = new System.Drawing.Size(100, 20);
      this.name7.TabIndex = 15;
      this.name7.Text = "Meeting room";
      // 
      // url6
      // 
      this.url6.Location = new System.Drawing.Point(131, 164);
      this.url6.Name = "url6";
      this.url6.Size = new System.Drawing.Size(468, 20);
      this.url6.TabIndex = 14;
      this.url6.Text = "https://d1zjbwmh9kbk11.cloudfront.net/a360-rendering/panorama/pano.html?url=16020" +
    "6/2111/cd07f095";
      // 
      // name6
      // 
      this.name6.Location = new System.Drawing.Point(24, 164);
      this.name6.Name = "name6";
      this.name6.Size = new System.Drawing.Size(100, 20);
      this.name6.TabIndex = 13;
      this.name6.Text = "Atrium";
      // 
      // name5
      // 
      this.name5.Location = new System.Drawing.Point(24, 137);
      this.name5.Name = "name5";
      this.name5.Size = new System.Drawing.Size(100, 20);
      this.name5.TabIndex = 11;
      this.name5.Text = "Another interior";
      // 
      // name4
      // 
      this.name4.Location = new System.Drawing.Point(24, 111);
      this.name4.Name = "name4";
      this.name4.Size = new System.Drawing.Size(100, 20);
      this.name4.TabIndex = 9;
      this.name4.Text = "Outside";
      // 
      // name3
      // 
      this.name3.Location = new System.Drawing.Point(24, 85);
      this.name3.Name = "name3";
      this.name3.Size = new System.Drawing.Size(100, 20);
      this.name3.TabIndex = 7;
      this.name3.Text = "Shared space";
      // 
      // name2
      // 
      this.name2.Location = new System.Drawing.Point(24, 59);
      this.name2.Name = "name2";
      this.name2.Size = new System.Drawing.Size(100, 20);
      this.name2.TabIndex = 5;
      this.name2.Text = "Extension";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, -20);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 13);
      this.label2.TabIndex = 16;
      this.label2.Text = "Raas URLs";
      // 
      // name1
      // 
      this.name1.Location = new System.Drawing.Point(24, 32);
      this.name1.Name = "name1";
      this.name1.Size = new System.Drawing.Size(100, 20);
      this.name1.TabIndex = 3;
      this.name1.Text = "Office";
      // 
      // url5
      // 
      this.url5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.url5.Location = new System.Drawing.Point(130, 136);
      this.url5.Name = "url5";
      this.url5.Size = new System.Drawing.Size(469, 20);
      this.url5.TabIndex = 12;
      this.url5.Text = "https://d1zjbwmh9kbk11.cloudfront.net/a360-rendering/panorama/pano.html?url=15111" +
    "7/1155/38fdf88d";
      // 
      // url4
      // 
      this.url4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.url4.Location = new System.Drawing.Point(130, 110);
      this.url4.Name = "url4";
      this.url4.Size = new System.Drawing.Size(469, 20);
      this.url4.TabIndex = 10;
      this.url4.Text = "https://d1zjbwmh9kbk11.cloudfront.net/a360-rendering/panorama/pano.html?url=16012" +
    "0/8245/05206103";
      // 
      // url3
      // 
      this.url3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.url3.Location = new System.Drawing.Point(130, 84);
      this.url3.Name = "url3";
      this.url3.Size = new System.Drawing.Size(469, 20);
      this.url3.TabIndex = 8;
      this.url3.Text = "https://d1zjbwmh9kbk11.cloudfront.net/a360-rendering/panorama/pano.html?url=16021" +
    "0/616/44e4643e";
      // 
      // url2
      // 
      this.url2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.url2.Location = new System.Drawing.Point(130, 58);
      this.url2.Name = "url2";
      this.url2.Size = new System.Drawing.Size(469, 20);
      this.url2.TabIndex = 6;
      this.url2.Text = "https://d1zjbwmh9kbk11.cloudfront.net/a360-rendering/panorama/pano.html?url=16021" +
    "7/969/127415fa";
      // 
      // url1
      // 
      this.url1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.url1.Location = new System.Drawing.Point(130, 32);
      this.url1.Name = "url1";
      this.url1.Size = new System.Drawing.Size(469, 20);
      this.url1.TabIndex = 4;
      this.url1.Text = "https://d1zjbwmh9kbk11.cloudfront.net/a360-rendering/panorama/pano.html?url=15111" +
    "7/4633/ba1741c4";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(-95, -20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Names";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(36, 305);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(102, 13);
      this.label4.TabIndex = 17;
      this.label4.Text = "Angle for thumbnails";
      // 
      // thumbnailAngle
      // 
      this.thumbnailAngle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.thumbnailAngle.Location = new System.Drawing.Point(145, 305);
      this.thumbnailAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
      this.thumbnailAngle.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.thumbnailAngle.Name = "thumbnailAngle";
      this.thumbnailAngle.Size = new System.Drawing.Size(54, 20);
      this.thumbnailAngle.TabIndex = 18;
      this.thumbnailAngle.Value = new decimal(new int[] {
            220,
            0,
            0,
            0});
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(643, 505);
      this.Controls.Add(this.thumbnailAngle);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.welcomeBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.logText);
      this.Controls.Add(this.ProcessButton);
      this.Name = "MainForm";
      this.Text = "RaaS to Krpano Extractor";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.thumbnailAngle)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button ProcessButton;
    private System.Windows.Forms.TextBox logText;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox welcomeBox;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox name5;
    private System.Windows.Forms.TextBox name4;
    private System.Windows.Forms.TextBox name3;
    private System.Windows.Forms.TextBox name2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox name1;
    private System.Windows.Forms.TextBox url5;
    private System.Windows.Forms.TextBox url4;
    private System.Windows.Forms.TextBox url3;
    private System.Windows.Forms.TextBox url2;
    private System.Windows.Forms.TextBox url1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox url7;
    private System.Windows.Forms.TextBox name7;
    private System.Windows.Forms.TextBox url6;
    private System.Windows.Forms.TextBox name6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown thumbnailAngle;
  }
}

