using R3;
using System;
using UnityEngine;

public class TutorialUIPresenter : MonoBehaviour
{
    [SerializeField] private TutorialUIModel tutorialUIModel;
    [SerializeField] private TutorialUIView tutorialUIView;
    void Awake()
    {
        tutorialUIView.OnNextClicked.Subscribe( value =>
        {
            tutorialUIModel.IncrementCount();
        });

        tutorialUIModel.OnPageChange.Subscribe( value =>
        {
            tutorialUIView.UpdateUI(value.image, value.name, tutorialUIModel.PageStatusText, "aa");
        });
    }
}
