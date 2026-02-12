using UnityEngine;

public class NPCControl : MonoBehaviour
{
    private NPCData npcData;

    private void Start()
    {
        npcData = GetComponent<NPCData>();
    }

    public void Interact()
    {
        DialogueManager.Instance.StartDialogue(npcData);
    }
}
