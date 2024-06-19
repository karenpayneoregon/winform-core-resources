using WinFormsApp2.Classes;

namespace WinFormsApp2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        DayPictureBox.Image = ResourceImages.Instance.BitMaps
            .FirstOrDefault(x => x.Name == DateTime.Now.DayOfWeek.ToString())!.Image;
    }
}
