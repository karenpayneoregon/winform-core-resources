using System.Collections;
using System.Globalization;
using System.Resources;

namespace WinFormsResourceLibrary.Classes;

public static class ResourceExtensions
{
    public static List<string> ResourceImageNames(this ResourceManager sender)
    {
        try
        {

            var names = new List<string>();
            var resourceSet = sender.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            names.AddRange(resourceSet!.Cast<DictionaryEntry>()
                .Where(dictionaryEntry => dictionaryEntry.Value is Image or Icon)
                .Select(dictionaryEntry => dictionaryEntry.Key.ToString()));

            return names;

        }
        catch (Exception)
        {
            return null;
        }
    }
}
