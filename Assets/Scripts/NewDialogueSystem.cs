using UnityEngine;
using UnityEngine.UI;

public class NewDialogueSystem : MonoBehaviour
{
    [Header("Настройки Ассета")]
    // Это ссылка на компонент Dialogues, который висит на NPC
    public Dialogues dialogueLogic; 

    [Header("UI Элементы")]
    public GameObject dialoguePanel;
    public Text uiDialogueText; // Переименовал, чтобы не путаться
    public Text npcNameText;
    public Button nextButton;

    private bool isDialogueActive = false;

    // Метод для запуска (можно вызвать извне или по кнопке)
    public void StartDialogue()
    {
        isDialogueActive = true;
        dialoguePanel.SetActive(true); // Показываем панель
        
        dialogueLogic.Reset(); // Сбрасываем дерево (функция ассета)
        UpdateUI();
        Debug.Log("Диалог начат!");
    }

    public void AdvanceDialogue()
    {
        // Вызываем Next() у логики ассета, а не у текста!
        int result = dialogueLogic.Next();

        if (result == -1) // Конец диалога
        {
            EndDialogue();
        }
        else if (result > 0) // Есть выбор (ветвление)
        {
            ShowChoices();
        }
        else // Просто следующая фраза
        {
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        // Берем текст из АССЕТА и записываем в UI ТЕКСТ
        uiDialogueText.text = dialogueLogic.GetCurrentDialogue();
        
        // Проверка триггеров через компонент ассета
        if (dialogueLogic.HasTrigger())
        {
            string triggerName = dialogueLogic.GetTrigger();
            ExecuteTrigger(triggerName);
        }
    }

    void ShowChoices()
    {
        string[] choices = dialogueLogic.GetChoices();
        Debug.Log("Появились варианты выбора!");
        // Здесь логика включения кнопок выбора
    }

    void ExecuteTrigger(string trigger)
    {
        if (trigger == "open_door") 
        {
            Debug.Log("Дверь открылась!");
        }
    }

    void EndDialogue()
    {
        isDialogueActive = false;
        dialoguePanel.SetActive(false); // Скрываем панель
        Debug.Log("Диалог окончен.");
    }
}