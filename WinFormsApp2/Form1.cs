using WinFormsApp2.Classes;
using static System.DateTime;

namespace WinFormsApp2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
        DayPictureBox.Image = ResourceImages.Instance.BitMaps
            .FirstOrDefault(x => x.Name == Now.DayOfWeek.ToString())!.Image;
    }
}
