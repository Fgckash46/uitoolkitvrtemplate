
using System;
using R3;
using UnityEngine;
using UnityEngine.UIElements;
public class CountUIView : MonoBehaviour
{
    public Subject<int> OnButtonClicked = new Subject<int>();
    public Subject<int> OnResetClicked = new Subject<int>();

    private Label label;
    void Awake()
    {
        var uiDocument = GetComponent<UIDocument>();
        var root = uiDocument.rootVisualElement;

        this.label = root.Q<Label>("counter-label");
        var countButton = root.Q<Button>("count-button");
        var resetButton = root.Q<Button>("reset-button");

        countButton.clicked += () => {
            OnButtonClicked.OnNext(1);
        };

        resetButton.clicked += () => {
            OnResetClicked.OnNext(1);
        };
    }

    public void SetText(int value)
    {
        this.label.text = value.ToString();
    }
    
}
