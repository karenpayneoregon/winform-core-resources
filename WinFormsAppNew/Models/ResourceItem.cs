
namespace WinFormsAppNew.Models;
/// <summary>
/// Represents a resource item that can either be a bitmap or an icon.
/// </summary>
/// <remarks>
/// This class is used to encapsulate resource items, providing properties to store
/// the name, image, and icon of the resource, as well as a flag indicating whether
/// the resource is an icon.
/// </remarks>
public class ResourceItem
{
    /// <summary>
    /// Resource name
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Image which is either an icon or bitmap
    /// </summary>
    public Bitmap? Image { get; set; }

    public Icon Icon { get; set; }
    /// <summary>
    /// Indicates if dealing with an icon so when displaying the
    /// control used to display can adjust it's size or Size mode
    /// </summary>
    public bool IsIcon { get; set; }

    public override string ToString() => Name;
}