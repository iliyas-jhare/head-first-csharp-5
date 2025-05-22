namespace ControlsExperiments;

public partial class MainPage
{
    int _count;

    public MainPage()
    {
        InitializeComponent();

        BirdPicker.ItemsSource = new[]
        {
            "🦅 Eagle",
            "🦆 Duck",
            "🦉 Owl",
            "🦇 Bat",
            "🦢 Swan",
            "🦜 Parrot",
            "🦚 Peacock",
            "🦩 Flamingo",
            "🦤 Dodo",
            "🦃 Turkey",
            "🐦 Bird",
            "🐧 Penguin",
            "🐤 Baby Chick",
            "🐔 Chicken",
            "🐓 Rooster",
            "🕊️ Dove"
        };
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        _count++;

        CounterBtn.Text = $"Clicked {_count} time{(_count == 1 ? string.Empty : "s")}";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void OnTextEntered(object? sender, TextChangedEventArgs e)
        => EnteredTextLabel.Text = e.NewTextValue;

    private void OnStepperValueChanged(object? sender, ValueChangedEventArgs e)
        => StepperValueLabel.Text = $"{e.NewValue}";

    private void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
        => SliderValueLabel.Text = $"{Math.Round(e.NewValue)}";

    private void OnAddBird(object? sender, EventArgs e)
    {
        if (BirdPicker.SelectedItem is string bird &&
            string.IsNullOrEmpty(bird) == false)
        {
            if (string.IsNullOrEmpty(BirdsLabel.Text))
            {
                BirdsLabel.Text = bird;
            }

            if (BirdsLabel.Text.Contains(bird) == false)
            {
                BirdsLabel.Text += Environment.NewLine + bird;
            }
        }
    }
}
