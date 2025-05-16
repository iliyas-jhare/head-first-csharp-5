namespace MatchAnimals;

public class AnimalButtonsLayoutModel
{
    private const int ButtonsCount = 16;

    private readonly FlexLayout _layout;
    private readonly AnimalButtonModel[] _buttonModels;

    private AnimalButtonModel? _selectedModel;

    public AnimalButtonsLayoutModel(FlexLayout layout, Button[] buttons)
    {
        _layout = layout;
        _buttonModels = buttons.Select(button => new AnimalButtonModel(button)).ToArray();

        Visible(false);
    }

    public bool CanHide()
        => _buttonModels.All(m => m.IsEmpty());

    public void Visible(bool flag = true)
        => _layout.IsVisible = flag;

    public void OnPlayButton()
    {
        Visible();
        SetAnimalButtonsText();
    }

    public void OnAnimalButton(Button button)
    {
        if (string.IsNullOrEmpty(button.Text))
        {
            return;
        }

        AnimalButtonModel model = _buttonModels.Single(m => m.Button == button);
        if (model.IsSame(_selectedModel) || model.HasDifferentText(_selectedModel))
        {
            ResetButtons(_buttonModels, resetBackgroundColor: true);

            _selectedModel = null;
        }
        else if (model.HasSameText(_selectedModel))
        {
            ResetButtons(
                models: _buttonModels.Where(m => m.HasSameText(_selectedModel)).ToArray(),
                resetBackgroundColor: true,
                resetText: true);

            _selectedModel = null;
        }
        else
        {
            model.SetBackgroundColor(AnimalButtonModel.SelectionColor);
            _selectedModel = model;
        }
    }

    private void SetAnimalButtonsText()
    {
        List<string> emojis = GetAnimalEmojis();
        Array.ForEach(_buttonModels, model => SetAnimalButtonText(model, emojis));
    }

    private static List<string> GetAnimalEmojis()
    {
        string[] emojis = Emojis.GetAnimalEmojis(ButtonsCount);
        return [.. emojis.Concat(emojis)];
    }

    private static void SetAnimalButtonText(AnimalButtonModel model, List<string> emojis)
    {
        int index = Random.Shared.Next(emojis.Count);
        model.SetText(emojis[index]);
        emojis.RemoveAt(index);
    }

    private static void ResetButtons(AnimalButtonModel[] models, bool resetBackgroundColor = false, bool resetText = false)
        => Array.ForEach(models, model => model.ResetButton(resetBackgroundColor, resetText));
}
