using UnityEngine;

public class NPCControl : MonoBehaviour
{
    // Компонент ассета Simple Dialogues, который висит на ЭТОМ NPC
    private Dialogues myDialogues;
    public NewDialogueSystem newDialogueSystem;

    private void Start()
    {
        // Ищем компонент диалогов на самом NPC
        myDialogues = GetComponent<Dialogues>();
    }

    public void Interact()
    {
        if (myDialogues != null)
        {
            // ПЕРЕДАЕМ свои диалоги системе и запускаем её
            newDialogueSystem.StartDialogue(myDialogues);
        }
        else
        {
            Debug.LogError("На этом NPC нет компонента Dialogues!");
        }
    }
}