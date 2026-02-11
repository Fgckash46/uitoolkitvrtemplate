using UnityEngine;

[CreateAssetMenu(fileName = "TutorialSO", menuName = "Tutorial/Page")]
public class TutorialSO : ScriptableObject
{
    public Sprite image;
    [TextArea(3, 10)] // インスペクターで入力しやすくする
    public string description;
}
