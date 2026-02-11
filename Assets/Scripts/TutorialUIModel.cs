using System;
using R3;
using UnityEngine;

public class TutorialUIModel : MonoBehaviour 
{
    [Header("チュートリアルデータ")]
    public TutorialSequenceSO sequence;
    // 現在のページインデックスを管理
    private readonly ReactiveProperty<int> _currentIndex = new ReactiveProperty<int>();
    
    // Presenterが購読するためのストリーム (現在のページデータを直接流す)
    public ReadOnlyReactiveProperty<TutorialSO> OnPageChange => 
        _currentIndex.Select(i => sequence.pages[i]).ToReadOnlyReactiveProperty();
    public bool IsLastPage => _currentIndex.Value >= sequence.pages.Count - 1;
    public string PageStatusText => $"{_currentIndex.Value + 1} / {sequence.pages.Count}";
    public void IncrementCount()
    {
        if (!IsLastPage) _currentIndex.Value++;
    }
}
