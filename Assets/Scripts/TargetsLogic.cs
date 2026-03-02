using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class TargetsLogic : MonoBehaviour
{

    [Header("UI")]
    public GameObject TargetPanel;
    public GameObject NewTextParent;
    public Text TargetText;
    [Header("Array")]
    List<string> TargetsNames = new List<string>();
    List<Text> Targets = new List<Text>();

    void Start()
    {
        AddTarget("Поговори с кем-то", "TalkWithSomeone");
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
        Targets.Add(NewText);
        TargetsNames.Add(TargetName);
    }

    public void CompleteTarget(string TargetName)
    {
        Targets[TargetsNames.IndexOf(TargetName)].text += "✅";
    }

}
