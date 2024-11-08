﻿using System.Resources;
using WinFormsResourceLibrary.Models;

namespace WinFormsResourceLibrary.Classes;

/// <summary>
/// Read images from current project resources
/// </summary>
public class ImageHelper
{

    /// <summary>
    /// Retrieves a list of resource items from the specified <see cref="ResourceManager"/>.
    /// </summary>
    /// <param name="sender">The <see cref="ResourceManager"/> instance containing the resources.</param>
    /// <returns>A list of <see cref="ResourceItem"/> objects representing the resources.</returns>
    public static List<ResourceItem> ResourceItemList(ResourceManager sender)
    {
        var items = new List<ResourceItem>();

        foreach (var name in sender.ResourceImageNames())
        {

            ResourceItem item = new() { Name = name, IsIcon = false };

            if (sender.GetObject(name) is Icon icon)
            {
                item.Image = ((Icon)sender.GetObject(name))?.ToBitmap();
                item.Icon = icon;
                item.IsIcon = true;
            }
            else
            {
                item.Image = (Bitmap)sender.GetObject(name);
            }

            items.Add(item);

        }

        return items;

    }
}