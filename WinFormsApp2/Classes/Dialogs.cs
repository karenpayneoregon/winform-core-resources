namespace WinFormsApp2.Classes;
/// <summary>
/// Provides methods for displaying dialog boxes.
/// </summary>
public static class Dialogs
{
    /// <summary>
    /// Displays an information dialog box.
    /// </summary>
    /// <param name="owner">The control that owns the dialog box.</param>
    /// <param name="heading">The heading text of the dialog box.</param>
    /// <param name="useFooter">Indicates whether to display a footer in the dialog box. Default is true.</param>
    public static void Information(Control owner, string heading, bool useFooter = true)
    {
        TaskDialogButton okayButton = new("OK");

        TaskDialogPage page = new()
        {
            Caption = "Information",
            SizeToContent = true,
            Heading = heading,
            Icon = new TaskDialogIcon(Properties.Resources.blueInformation_32),
            Buttons = [okayButton]
        };

        if (useFooter)
        {
            page.Footnote = new TaskDialogFootnote() { Text = "Karen Payne code sample" };
        }

        TaskDialog.ShowDialog(owner, page);
    }
}
