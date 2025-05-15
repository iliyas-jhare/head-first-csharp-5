namespace MatchAnimals;

public partial class MainPage
{
    private readonly PlayButtonModel _playButtonModel;
    private readonly AnimalButtonsLayoutModel _animalButtonsLayoutModel;

    private int _tenthOfSecondsElapsed;

    public MainPage()
    {
        InitializeComponent();

        _playButtonModel = new PlayButtonModel(PlayButton);
        _animalButtonsLayoutModel = new AnimalButtonsLayoutModel(
            layout: AnimalButtonsLayout,
            buttons: AnimalButtonsLayout.Children.OfType<Button>().ToArray());
    }

    private void OnPlayButton(object? sender, EventArgs e)
    {
        _playButtonModel.Visible(false);
        _animalButtonsLayoutModel.OnPlayButton();

        Dispatcher.StartTimer(TimeSpan.FromSeconds(0.1), TimerTick);
    }

    private void OnAnimalButton(object? sender, EventArgs e)
    {
        if (sender is Button button)
        {
            _animalButtonsLayoutModel.OnAnimalButton(button);

            if (_animalButtonsLayoutModel.CanHide())
            {
                _playButtonModel.Visible();
                _animalButtonsLayoutModel.Visible(false);
            }
        }
    }

    private bool TimerTick()
    {
        if (!this.IsLoaded)
        {
            return false;
        }

        _tenthOfSecondsElapsed++;

        TimeElapsedLabel.Text = $"Time Elapsed: {(_tenthOfSecondsElapsed / 10F):0.0s}";

        if (PlayButton.IsVisible)
        {
            _tenthOfSecondsElapsed = 0;
        }

        return !PlayButton.IsVisible;
    }
}
