using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class TargetsLogic : MonoBehaviour
{

    [Header("UI")]
    public GameObject TargetPanel;
    public GameObject NewTextParent;
    public Text TargetTextObj;
    [Header("Array")]
    private Dictionary<string, Text> targetsMap = new Dictionary<string, Text>();

    public void ShowTargetPanel()
    {
        TargetPanel.SetActive(true);
    }

    public void AddTarget(string TargetText, string TargetName)
    {
        Text NewText = Instantiate(TargetTextObj);
        NewText.transform.SetParent(NewTextParent.transform, false);
        NewText.text = TargetText;
        NewText.gameObject.name = TargetName;
        targetsMap.Add(TargetName, NewText);
    }

    public void CompleteTarget(string TargetName)
    {
        if (targetsMap.ContainsKey(TargetName))
        {
            targetsMap[TargetName].text += " ✅";
        }
        else
        {
            Debug.LogWarning($"Цель с именем {TargetName} не найдена!");
        }
    }

}
