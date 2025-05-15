namespace MatchAnimals;

public class PlayButtonModel
{
    private readonly Button _playButton;

    public PlayButtonModel(Button playButton)
    {
        _playButton = playButton;

        Visible();
    }

    public void Visible(bool flag = true)
        => _playButton.IsVisible = flag;
}
