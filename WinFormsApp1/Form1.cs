using WinFormsApp1.Classes;
using WinFormsResourceLibrary.Models;


#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        if (ResourceImages.Instance.HasIcons)
        {
            IconListBox.DataSource = ResourceImages.Instance.Icons;
            IconListBox.SelectedIndexChanged += IconListBoxOnSelectedIndexChanged;
            IconListBox.SelectedIndex = IconListBox.FindString("Csharp");
        }

        if (ResourceImages.Instance.HasBitmaps)
        {
            BitmapListBox.DataSource = ResourceImages.Instance.BitMaps;
            BitmapListBox.SelectedIndexChanged += BitmapListBoxOnSelectedIndexChanged;
            BitmapListBox.SelectedIndex = BitmapListBox.FindString("earth-11602");
        }

        var images = ResourceImages.Instance.Images;
        imageCountLabel.Text = $"There are {images.Count} in this project's resources";
    }

    private void ShowCurrentIcon()
    {
        if (IconListBox.SelectedIndex <= -1) return;
        var item = (ResourceItem)IconListBox.SelectedItem;
        pictureBox1.SizeMode = item!.IsIcon ? PictureBoxSizeMode.Normal : PictureBoxSizeMode.Zoom;
        pictureBox1.Image = item.Image;
        // change this form's icon
        Icon = item.Icon;
    }

    private void IconListBoxOnSelectedIndexChanged(object sender, EventArgs e)
    {
        ShowCurrentIcon();
    }

    private void ShowCurrentBitmap()
    {
        if (BitmapListBox.SelectedIndex <= -1) return;
        var item = (ResourceItem)BitmapListBox.SelectedItem;
        pictureBox2.SizeMode = item!.IsIcon ? PictureBoxSizeMode.Normal : PictureBoxSizeMode.Zoom;
        pictureBox2.Image = item.Image;
    }

    private void BitmapListBoxOnSelectedIndexChanged(object? sender, EventArgs e)
    {
        ShowCurrentBitmap();
    }

    private void AboutButton_Click(object sender, EventArgs e)
    {
        Information(AboutButton, "Resource helpers");
    }
}
