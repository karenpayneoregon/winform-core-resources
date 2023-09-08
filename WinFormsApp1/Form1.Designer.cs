namespace WinFormsApp1;

partial class Form1
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
        IconListBox = new ListBox();
        pictureBox1 = new PictureBox();
        BitmapListBox = new ListBox();
        pictureBox2 = new PictureBox();
        label1 = new Label();
        label2 = new Label();
        imageCountLabel = new Label();
        AboutButton = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // IconListBox
        // 
        IconListBox.FormattingEnabled = true;
        IconListBox.ItemHeight = 20;
        IconListBox.Location = new Point(12, 43);
        IconListBox.Name = "IconListBox";
        IconListBox.Size = new Size(217, 384);
        IconListBox.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(258, 43);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(125, 62);
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // BitmapListBox
        // 
        BitmapListBox.FormattingEnabled = true;
        BitmapListBox.ItemHeight = 20;
        BitmapListBox.Location = new Point(407, 43);
        BitmapListBox.Name = "BitmapListBox";
        BitmapListBox.Size = new Size(217, 384);
        BitmapListBox.TabIndex = 2;
        // 
        // pictureBox2
        // 
        pictureBox2.Location = new Point(646, 43);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(125, 62);
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 20);
        label1.Name = "label1";
        label1.Size = new Size(43, 20);
        label1.TabIndex = 4;
        label1.Text = "Icons";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(410, 17);
        label2.Name = "label2";
        label2.Size = new Size(63, 20);
        label2.TabIndex = 5;
        label2.Text = "Bitmaps";
        // 
        // imageCountLabel
        // 
        imageCountLabel.AutoSize = true;
        imageCountLabel.Location = new Point(12, 467);
        imageCountLabel.Name = "imageCountLabel";
        imageCountLabel.Size = new Size(50, 20);
        imageCountLabel.TabIndex = 6;
        imageCountLabel.Text = "label3";
        // 
        // AboutButton
        // 
        AboutButton.Location = new Point(694, 455);
        AboutButton.Name = "AboutButton";
        AboutButton.Size = new Size(94, 29);
        AboutButton.TabIndex = 7;
        AboutButton.Text = "About";
        AboutButton.UseVisualStyleBackColor = true;
        AboutButton.Click += AboutButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 496);
        Controls.Add(AboutButton);
        Controls.Add(imageCountLabel);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(pictureBox2);
        Controls.Add(BitmapListBox);
        Controls.Add(pictureBox1);
        Controls.Add(IconListBox);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Code sample";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox IconListBox;
    private PictureBox pictureBox1;
    private ListBox BitmapListBox;
    private PictureBox pictureBox2;
    private Label label1;
    private Label label2;
    private Label imageCountLabel;
    private Button AboutButton;
}
