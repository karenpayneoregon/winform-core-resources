using System.Collections;
using System.Globalization;
using System.Resources;

namespace WinFormsResourceLibrary;

public static class ResourceExtensions
{
    public static List<string> ResourceImageNames(this ResourceManager sender)
    {
        try
        {

            var names = new List<string>();
            var resourceSet = sender
                .GetResourceSet(CultureInfo.CurrentUICulture, true, true);

            names.AddRange(
                from DictionaryEntry dictionaryEntry in resourceSet
                where dictionaryEntry.Value is Image || dictionaryEntry.Value is Icon
                select dictionaryEntry.Key.ToString());

            return names;

        }
        catch (Exception)
        {
            return null;
        }
    }
}
