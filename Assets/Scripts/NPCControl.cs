using UnityEngine;

public class NPCControl : MonoBehaviour
{
    private NPCData npcData;
    public NewDialogueSystem newDialogueSystem;

    private void Start()
    {
        npcData = GetComponent<NPCData>();
    }

    public void Interact()
    {
        newDialogueSystem.StartDialogue();
    }
}
