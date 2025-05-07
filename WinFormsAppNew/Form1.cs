using WinFormsAppNew.Classes;

namespace WinFormsAppNew;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

    }

    private void ExamineButton_Click(object sender, EventArgs e)
    {
        pictureBox1.Image = ResourceImages.Instance.Icons
            .FirstOrDefault(x => x.Name == "password")!.Image;
    }

    private void Examine1Button_Click(object sender, EventArgs e)
    {
        pictureBox1.Image = ResourceImages.Instance.BitMaps
            .FirstOrDefault(x => x.Name == "blub")!.Image;
    }
}
