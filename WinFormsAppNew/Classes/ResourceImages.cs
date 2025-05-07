using WinFormsAppNew.Models;
using WinFormsAppNew.Properties;

namespace WinFormsAppNew.Classes;

/// <summary>
/// Provides a singleton instance to access and manage icon and bitmap images from the project's resources.
/// </summary>
/// <remarks>
/// The <see cref="ResourceImages"/> class is designed to load and organize resource items, such as icons and bitmaps,
/// from the project's resources. It categorizes the resources into separate collections for icons and bitmaps,
/// making them easily accessible for use in the application.
/// </remarks>
public sealed class ResourceImages
{
    private static readonly Lazy<ResourceImages> Lazy = new(() => new ResourceImages());

    public static ResourceImages Instance => Lazy.Value;

    /// <summary>
    /// Get all icon and bitmap images from project resources
    /// </summary>
    public List<ResourceItem> Images;

    /// <summary>
    /// Icons from resources
    /// </summary>
    public List<ResourceItem> Icons;

    /// <summary>
    /// BitMaps from resources
    /// </summary>
    public List<ResourceItem> BitMaps;

    /// <summary>
    /// Initializes a new instance of the <see cref="ResourceImages"/> class.
    /// </summary>
    /// <remarks>
    /// This constructor initializes the <see cref="Images"/>, <see cref="Icons"/>, and <see cref="BitMaps"/> properties
    /// by loading resource items from the project's resources.
    /// </remarks>
    private ResourceImages()
    {
        Images = ImageHelper.ResourceItemList(Resources.ResourceManager);

        Icons = Images.Where(resourceItem => resourceItem.IsIcon)
            .OrderBy(resourceItem => resourceItem.Name)
            .ToList();

        BitMaps = Images.Where(resourceItem => !resourceItem.IsIcon)
            .OrderBy(resourceItem => resourceItem.Name)
            .ToList();
    }
}
