using R3;
using UnityEngine;

public class CountUIModel : MonoBehaviour 
{
    private int _count;
    public ReactiveProperty<int> OnCountChange = new ReactiveProperty<int>();

    public int Count
    {
        get
        {
            return _count;
        }
        private set
        {
            _count = value;
            OnCountChange.Value = _count;
        }
    }

    public void IncrementCount()
    {
        Count++;
    }

    public void ResetCount()
    {
        Count = 0;
    }
}
