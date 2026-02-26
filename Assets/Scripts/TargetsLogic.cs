using UnityEngine;
using UnityEngine.UI;

public class TargetsLogic : MonoBehaviour
{

    [Header("UI")]
    public GameObject TargetPanel;
    public GameObject NewTextParent;
    public Text TargetText;

    void Start()
    {    
        ShowTargetPanel();
        for(int i = 0; i < 10; i++) AddTarget("Поговори с кем-то", "Talk");
    }

    public void ShowTargetPanel()
    {
        TargetPanel.SetActive(true);
    }

    public void AddTarget(string NewTarget, string TargetName)
    {
        Text NewText = Instantiate(TargetText);
        NewText.transform.SetParent(NewTextParent.transform, false);
        NewText.text = NewTarget;
        NewText.gameObject.name = TargetName;
    }

}
