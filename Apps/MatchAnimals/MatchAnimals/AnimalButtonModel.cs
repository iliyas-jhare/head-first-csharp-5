namespace MatchAnimals;

public class AnimalButtonModel(Button button)
{
    public static Color ResetColor => Colors.Cyan;

    public static Color SelectionColor => Colors.OrangeRed;

    public Button Button => button;

    public bool IsEmpty()
        => string.IsNullOrEmpty(button.Text);

    public void SetText(string text)
        => button.Text = text;

    public void SetBackgroundColor(Color color)
        => button.BackgroundColor = color;

    public void ResetButton(bool resetBackgroundColor = false, bool resetText = false)
    {
        button.BackgroundColor = resetBackgroundColor ? ResetColor : button.BackgroundColor;
        button.Text = resetText ? string.Empty : button.Text;
    }

    public bool IsSame(AnimalButtonModel? other)
        => button == other?.Button;

    public bool HasSameText(AnimalButtonModel? other)
        => !string.IsNullOrEmpty(other?.Button.Text) &&
           button.Text == other.Button.Text;

    public bool HasDifferentText(AnimalButtonModel? other)
        => !string.IsNullOrEmpty(other?.Button.Text) &&
           button.Text != other.Button.Text;
}