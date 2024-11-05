namespace WinFormsApp1.Classes;
/// <summary>
/// Provides methods for displaying dialog boxes.
/// </summary>
public static class Dialogs
{
    /// <summary>
    /// Displays an information dialog box with a specified heading and an optional footer.
    /// </summary>
    /// <param name="owner">The control that will own the modal dialog box.</param>
    /// <param name="heading">The heading text to be displayed in the dialog box.</param>
    /// <param name="useFooter">A boolean value indicating whether to display a footer in the dialog box.</param>
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
