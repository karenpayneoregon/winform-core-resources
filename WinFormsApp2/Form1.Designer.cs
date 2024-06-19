namespace WinFormsApp2;

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
        DayPictureBox = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)DayPictureBox).BeginInit();
        SuspendLayout();
        // 
        // DayPictureBox
        // 
        DayPictureBox.Location = new Point(89, 53);
        DayPictureBox.Name = "DayPictureBox";
        DayPictureBox.Size = new Size(194, 133);
        DayPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        DayPictureBox.TabIndex = 0;
        DayPictureBox.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(347, 238);
        Controls.Add(DayPictureBox);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Day of week";
        ((System.ComponentModel.ISupportInitialize)DayPictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox DayPictureBox;
}
