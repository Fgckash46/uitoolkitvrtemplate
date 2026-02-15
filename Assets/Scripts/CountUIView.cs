
using System;
using R3;
using UnityEngine;
using UnityEngine.UIElements;
public class CountUIView : MonoBehaviour
{
    public Subject<int> OnButtonClicked = new Subject<int>();
    public Subject<int> OnResetClicked = new Subject<int>();

    public Subject<int> OnConfirmClicked = new Subject<int>();

    public Subject<int> OnCancelClicked = new Subject<int>();

    private Label label;
    void OnEnable()
    {
        var uiDocument = GetComponent<UIDocument>();
        var root = uiDocument.rootVisualElement;

        this.label = root.Q<Label>("counter-label");
        var countButton = root.Q<Button>("count-button");
        var resetButton = root.Q<Button>("reset-button");
        var confirmButton = root.Q<Button>("dialog-confirm");
        var cancelButton = root.Q<Button>("dialog-cancel");
        var _overlay = root.Q<VisualElement>("reset-confirm");

        _overlay.style.display = DisplayStyle.None;

        countButton.clicked += () => {
            OnButtonClicked.OnNext(1);
        };

        resetButton.clicked += () => {
            _overlay.style.display = DisplayStyle.Flex;
        };

        confirmButton.clicked += () => {
            _overlay.style.display = DisplayStyle.None;
            _overlay.schedule.Execute(() => _overlay.style.display = DisplayStyle.None).StartingIn(200);
            OnResetClicked.OnNext(1);
            
        };

        cancelButton.clicked += () => {
            _overlay.style.display = DisplayStyle.None;
            _overlay.schedule.Execute(() => _overlay.style.display = DisplayStyle.None).StartingIn(200);
        };
    }

    public void SetText(int value)
    {
        this.label.text = value.ToString();
    }
    
}
