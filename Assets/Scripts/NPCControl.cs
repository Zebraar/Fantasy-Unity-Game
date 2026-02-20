using UnityEngine;

public class NPCControl : MonoBehaviour
{
    private Dialogues myDialogues; // Ссылка на Dialogues именно этого NPC
    public NewDialogueSystem dialogueSystem; // Ссылка на менеджер на сцене

    void Start()
    {
        // Берем компонент Dialogues с этого же объекта (с NPC)
        myDialogues = GetComponent<Dialogues>();
    }

    public void Interact()
    {
        // Передаем СВОИ диалоги в общую систему
        dialogueSystem.StartDialogue(myDialogues);
    }
}