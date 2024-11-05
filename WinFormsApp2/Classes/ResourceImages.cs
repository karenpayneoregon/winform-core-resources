using WinFormsApp2.Properties;
using WinFormsResourceLibrary.Classes;
using WinFormsResourceLibrary.Models;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace WinFormsApp2.Classes;

/// <summary>
/// Provides a singleton instance to access icon and bitmap images from project resources.
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
    /// Initializes a new instance of the <see cref="ResourceImages"/> class.
    /// </summary>
    /// <remarks>
    /// This constructor initializes the <see cref="Images"/>, <see cref="Icons"/>, and <see cref="BitMaps"/> properties
    /// by loading resource items from the project's resources.
    /// </remarks>
    private ResourceImages()
    {
        Images = ImageHelper.ResourceItemList(Resources.ResourceManager);

        BitMaps = Images.Where(resourceItem => resourceItem.IsIcon == false)
            .OrderBy(resourceItem => resourceItem.Name)
            .ToList();

    }
}