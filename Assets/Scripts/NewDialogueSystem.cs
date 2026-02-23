using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class NewDialogueSystem : MonoBehaviour
{
    [Header("Настройки Ассета")]
    public Dialogues dialogueLogic; 

    [Header("UI Элементы")]
    public GameObject dialoguePanel;
    public Text uiDialogueText;
    public Button nextButton;
    public GameObject choicePanel;
    public Button[] choiceButtons;

    public void StartDialogue(Dialogues npcDialogues) 
    {
        if (npcDialogues == null) return;

        // Подменяем текущую логику на логику того NPC, с которым говорим
        dialogueLogic = npcDialogues; 
    
        dialoguePanel.SetActive(true);
        dialogueLogic.Reset(); // Сбрасываем дерево конкретно этого NPC
        UpdateUI();
    
        Debug.Log("Говорим с: " + npcDialogues.gameObject.name);
    }

    public void AdvanceDialogue()
    {
        int result = dialogueLogic.Next();
        if (result == -1) EndDialogue();
        if (result > 0) Choice(result);
        else UpdateUI();
    }

    void UpdateUI()
    {
        if (uiDialogueText != null) {
            uiDialogueText.text = dialogueLogic.GetCurrentDialogue();
            if (dialogueLogic.HasTrigger() == true)
            {
                Trigger(dialogueLogic.GetTrigger());
            }
        }
    }

    public void Choice(int choicesAmount)
    {
        string[] choices = dialogueLogic.GetChoices();
        choicePanel.SetActive(true);
        for (int i = 0; i < choicesAmount; i++) 
        {
            choiceButtons[i].gameObject.SetActive(true);
            choiceButtons[i].gameObject.GetComponentInChildren<Text>().text = choices[i];
        }
    }

    public void ShowNextChoice(int buttonNum)
    {
        string playerChoice = choiceButtons[buttonNum].gameObject.GetComponentInChildren<Text>().text;
        dialogueLogic.NextChoice(playerChoice);
        choicePanel.SetActive(false);
        UpdateUI();
    }

    public void Trigger(string triggerName)
    {
        
    }

    public void EndDialogue()
    {
        dialoguePanel.SetActive(false);
        Debug.Log("Диалог окончен.");
    }
}