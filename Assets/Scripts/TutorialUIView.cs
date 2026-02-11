
using System;
using R3;
using UnityEngine;
using UnityEngine.UIElements;
public class TutorialUIView : MonoBehaviour
{
    public Subject<int> OnNextClicked = new Subject<int>();

    private VisualElement _imageHolder;
    private Label _descLabel;
    private Label _pageIndicator;
    private Button _nextButton;
    void OnEnable()
    {
        var uiDocument = GetComponent<UIDocument>();
        var root = uiDocument.rootVisualElement;

        _imageHolder = root.Q<VisualElement>("image-holder");
        _descLabel = root.Q<Label>("desc-label");
        _pageIndicator = root.Q<Label>("page-indicator");
        _nextButton = root.Q<Button>("next-button");

        _nextButton.clicked += () =>
        {
            OnNextClicked.OnNext(1);
        };
    }
    
    public void UpdateUI(Sprite img, string text, string pageText, string buttonText)
    {
        _imageHolder.style.backgroundImage = new StyleBackground(img);
        _descLabel.text = text;
        _pageIndicator.text = pageText;
        _nextButton.text = buttonText;
    }
}
