using R3;
using System;
using UnityEngine;

public class CountUIPresenter : MonoBehaviour
{
    [SerializeField] private CountUIModel countUIModel;
    [SerializeField] private CountUIView countUIView;
    void Awake()
    {
        countUIView.OnButtonClicked.Subscribe( value =>
        {
            countUIModel.IncrementCount();
        });

        countUIView.OnResetClicked.Subscribe( value =>
        {
            countUIModel.ResetCount();
        });

        countUIModel.OnCountChange.Subscribe( x =>
        {
            countUIView.SetText(x);
        });
    }
}
