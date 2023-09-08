using WinFormsResourceLibrary;
using WinFormsApp1.Properties;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace WinFormsApp1.Classes;

/// <summary>
/// Provides access to resource images by loading them once
/// </summary>
public sealed class ResourceImages
{
    private static readonly Lazy<ResourceImages> Lazy = new(() => new ResourceImages());

    public static ResourceImages Instance => Lazy.Value;

    private List<ResourceItem> _images;
    /// <summary>
    /// Get all icon and bitmap images from project resources
    /// </summary>
    /// <returns>list of images</returns>
    public List<ResourceItem> Images() 
        => _images ??= ImageHelper.ResourceItemList(Resources.ResourceManager);

    /// <summary>
    /// Icons from resources
    /// </summary>
    public List<ResourceItem> Icons => Images().Where(resourceItem 
        => resourceItem.IsIcon).OrderBy(resourceItem => resourceItem.Name).ToList();
    /// <summary>
    /// BitMaps from resources
    /// </summary>
    public List<ResourceItem> BitMaps => Images().Where(resourceItem
        => resourceItem.IsIcon == false).OrderBy(resourceItem => resourceItem.Name).ToList();

    /// <summary>
    /// Are there any icons in resources
    /// </summary>
    public bool HasIcons => Icons.Any();
    /// <summary>
    /// Are there any icons in resources
    /// </summary>
    public bool HasBitmaps => BitMaps.Any();
}