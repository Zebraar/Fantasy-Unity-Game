using UnityEngine;
using UnityEngine.UI;

public class TargetsLogic : MonoBehaviour
{

    [Header("UI")]
    public GameObject TargetPanel;
    public Text TargetText;

    void Start()
    {
        ShowTargetPanel();
        AddTarget("Поговори с кем-то", "Talk");
    }

    public void ShowTargetPanel()
    {
        TargetPanel.SetActive(true);
    }

    public void AddTarget(string NewTarget, string TargetName)
    {
        Text NewText = Instantiate(TargetText);
        NewText.transform.SetParent(TargetPanel.transform, false);
        NewText.text = NewTarget;
        NewText.gameObject.name = TargetName;
    }

}
