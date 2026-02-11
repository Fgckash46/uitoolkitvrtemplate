using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewTutorialSequence", menuName = "Tutorial/Sequence")]
public class TutorialSequenceSO : ScriptableObject
{
    public List<TutorialSO> pages;
}