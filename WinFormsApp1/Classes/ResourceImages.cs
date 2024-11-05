using WinFormsApp1.Properties;
using WinFormsResourceLibrary.Models;
using WinFormsResourceLibrary.Classes;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace WinFormsApp1.Classes;

/// <summary>
/// Provides access to icon and bitmap images from the project's resources.
/// This class implements the singleton pattern to ensure a single instance is used throughout the application.
/// </summary>
public sealed class ResourceImages
{
    private static readonly Lazy<ResourceImages> Lazy = new(() => new ResourceImages());

    public static ResourceImages Instance => Lazy.Value;

    /// <summary>
    /// Get all icon and bitmap images from project resources
    /// </summary>
    /// <returns>list of images</returns>
    public List<ResourceItem> Images ;

    /// <summary>
    /// Icons from resources
    /// </summary>
    public List<ResourceItem> Icons;
    /// <summary>
    /// BitMaps from resources
    /// </summary>
    public List<ResourceItem> BitMaps;

    /// <summary>
    /// Gets a value indicating whether there are any icons available in the resources.
    /// </summary>
    /// <value>
    /// <c>true</c> if there are icons available; otherwise, <c>false</c>.
    /// </value>
    public bool HasIcons => Icons.Any();
    /// <summary>
    /// Are there any icons in resources
    /// </summary>
    public bool HasBitmaps => BitMaps.Any();

    private ResourceImages()
    {
        Images = ImageHelper.ResourceItemList(Resources.ResourceManager);

        BitMaps = Images.Where(resourceItem => resourceItem.IsIcon == false)
            .OrderBy(resourceItem => resourceItem.Name)
            .ToList();

        Icons = Images.Where(resourceItem => resourceItem.IsIcon)
            .OrderBy(resourceItem => resourceItem.Name)
            .ToList();
    }
}