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

    public void StartDialogue(Dialogues newLogic)
    {
        if (newLogic == null) {
            Debug.LogError("Критическая ошибка: NPC не передал свои диалоги!");
            return;
        }

        dialogueLogic = newLogic;
        
        if (dialoguePanel == null) {
            Debug.LogError("Критическая ошибка: В инспекторе не перетащена DialoguePanel!");
            return;
        }

        // ВКЛЮЧАЕМ ПАНЕЛЬ
        dialoguePanel.SetActive(true);
        
        // ПРОВЕРКА РОДИТЕЛЯ (Canvas)
        Canvas parentCanvas = dialoguePanel.GetComponentInParent<Canvas>();
        if (parentCanvas != null && !parentCanvas.gameObject.activeInHierarchy) {
            Debug.LogWarning("ВНИМАНИЕ: Панель включена, но её Canvas выключен! Включаю Canvas...");
            parentCanvas.gameObject.SetActive(true);
        }

        dialogueLogic.Reset();
        UpdateUI();
        Debug.Log("Скрипт: Панель должна быть видна сейчас. Текст: " + dialogueLogic.GetCurrentDialogue());
    }

    public void AdvanceDialogue()
    {
        int result = dialogueLogic.Next();
        if (result == -1) EndDialogue();
        else UpdateUI();
    }

    void UpdateUI()
    {
        if (uiDialogueText != null) {
            uiDialogueText.text = dialogueLogic.GetCurrentDialogue();
        }
    }

    public void EndDialogue()
    {
        dialoguePanel.SetActive(false);
        Debug.Log("Диалог окончен.");
    }
}