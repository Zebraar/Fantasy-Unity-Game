using UnityEngine;
using UnityEngine.UI;

public class TargetsLogic : MonoBehaviour
{

    [Header("UI")]
    public GameObject TargetPanel;
    public Text TargetText;

    public void ShowTargetPanel()
    {
        TargetPanel.SetActive(true);
    }

    public void AddTarget(string NewTarget, string TargetName)
    {
        Text NewText = Instantiate(TargetText);
        NewText.text = NewTarget;
        NewText.gameObject.name = TargetName;
    }

}
