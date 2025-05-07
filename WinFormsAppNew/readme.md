How to get images from resources.

Prior to NET9 resources were strong typed

```csharp
/// <summary>
///   Looks up a localized resource of type System.Drawing.Bitmap.
/// </summary>
internal static System.Drawing.Bitmap tree1 {
    get {
        object obj = ResourceManager.GetObject("tree1", resourceCulture);
        return ((System.Drawing.Bitmap)(obj));
    }
}
        
/// <summary>
///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
/// </summary>
internal static System.Drawing.Icon WindowsForm_16x {
    get {
        object obj = ResourceManager.GetObject("WindowsForm_16x", resourceCulture);
        return ((System.Drawing.Icon)(obj));
    }
}
```

After NET 9 resources are no longer strong typed. 
```csharp

/// <summary>
///   Looks up a localized resource of type System.Byte[].
/// </summary>
internal static byte[] blub {
    get {
        object obj = ResourceManager.GetObject("blub", resourceCulture);
        return ((byte[])(obj));
    }
}
        
/// <summary>
///   Looks up a localized resource of type System.Byte[].
/// </summary>
internal static byte[] password {
    get {
        object obj = ResourceManager.GetObject("password", resourceCulture);
        return ((byte[])(obj));
    }
}
```

- Code has been altered for NET9
- Picture box does not see resources

## In closing

What is left is to create a new class project which mirrors `WinFormsResourceLibrary`