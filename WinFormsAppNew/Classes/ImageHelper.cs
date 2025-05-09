﻿using System.Resources;
using WinFormsAppNew.Models;

namespace WinFormsAppNew.Classes;

/// <summary>
/// Provides utility methods for processing and retrieving image-related resources 
/// from a <see cref="ResourceManager"/>.
/// </summary>
/// <remarks>
/// This class is designed to facilitate the extraction and categorization of image resources, 
/// such as icons, bitmaps, and byte arrays representing images, from a resource manager.
/// It supports scenarios where resources are stored in various formats and ensures 
/// they are appropriately processed into <see cref="ResourceItem"/> objects.
/// </remarks>
public class ImageHelper
{
    /// <summary>
    /// Retrieves a list of <see cref="ResourceItem"/> objects from the specified <see cref="ResourceManager"/>.
    /// </summary>
    /// <param name="sender">The <see cref="ResourceManager"/> instance containing the resources to process.</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    /// <returns>
    /// A list of <see cref="ResourceItem"/> objects, where each item represents a resource.
    /// The resource can be an image, an icon, or a bitmap.
    /// </returns>
    /// <remarks>
    /// This method iterates through the resource names provided by the <see cref="ResourceManager"/>.
    /// For each resource, it determines whether it is an icon, a bitmap, or a byte array representing an image.
    /// It then creates a corresponding <see cref="ResourceItem"/> object and adds it to the list.
    /// 
    /// In the past, adding an image to the resources would add it as a Bitmap but now as a byte array.
    /// </remarks>
    public static List<ResourceItem> ResourceItemList(ResourceManager sender)
    {
        var items = new List<ResourceItem>();

        foreach (var name in sender.ResourceImageNames())
        {

            ResourceItem item = new() { Name = name, IsIcon = false };

            var byteArray = sender.GetObject(name) as byte[];

            var imageType = GetImageType(byteArray);

            switch (imageType)
            {
                case ImageType.Icon:
                {
                    var b = sender.GetObject(name) as byte[];
                    var icon = IconHelper.ByteArrayToIcon(b);
                    if (icon != null)
                    {
                        item.Image = icon.ToBitmap();
                        item.Icon = icon;
                        item.IsIcon = true;
                    }

                    break;
                }
                case ImageType.Bitmap:
                {
                    if (sender.GetObject(name) is byte[] bytes)
                    {
                        using MemoryStream ms = new(bytes);
                        item.Image = new Bitmap(ms);
                    }

                    break;
                }
                case ImageType.Png when sender.GetObject(name) is byte[] pngBytes:
                {
                    using MemoryStream ms = new(pngBytes);
                    item.Image = new Bitmap(ms);
                    break;
                }
                case ImageType.Unknown:
                case ImageType.Jpeg:
                    break;
            }

            if (item.Image is not null)
            {
                items.Add(item);
            }

        }

        return items;

    }

    /// <summary>
    /// Determines the type of image based on its byte array representation.
    /// </summary>
    /// <param name="bytes">The byte array containing the image data. Can be <c>null</c>.</param>
    /// <returns>
    /// An <see cref="ImageType"/> value indicating the type of the image.
    /// Returns <see cref="ImageType.Unknown"/> if the byte array is <c>null</c>, too short, 
    /// or does not match any known image format.
    /// </returns>
    private static ImageType GetImageType(byte[]? bytes)
    {
        if (bytes == null || bytes.Length < 8)
            return ImageType.Unknown;

        // BMP: 'B' 'M'
        if (bytes[0] == 0x42 && bytes[1] == 0x4D)
            return ImageType.Bitmap;

        // ICO: 00 00 01 00
        if (bytes[0] == 0x00 && bytes[1] == 0x00 &&
            bytes[2] == 0x01 && bytes[3] == 0x00)
            return ImageType.Icon;

        // PNG: 89 50 4E 47 0D 0A 1A 0A
        if (bytes[0] == 0x89 && bytes[1] == 0x50 &&
            bytes[2] == 0x4E && bytes[3] == 0x47 &&
            bytes[4] == 0x0D && bytes[5] == 0x0A &&
            bytes[6] == 0x1A && bytes[7] == 0x0A)
            return ImageType.Png;

        // JPEG: FF D8
        if (bytes[0] == 0xFF && bytes[1] == 0xD8)
            return ImageType.Jpeg;

        return ImageType.Unknown;

    }


}