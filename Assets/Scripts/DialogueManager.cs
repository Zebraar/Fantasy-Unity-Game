using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;

    [Header("UI")]
    public GameObject dialoguePanel;
    public Text dialogueText;
    public Text NPCNameText;
    public Button nextButton;

    private NPCData currentNPC;
    private int replicaIndex;

    private void Awake()
    {
        Instance = this;
        dialoguePanel.SetActive(false);

        // Кнопка ВСЕГДА вызывает менеджер
        nextButton.onClick.RemoveAllListeners();
        nextButton.onClick.AddListener(NextReplica);
    }

    public void StartDialogue(NPCData npc)
    {
        currentNPC = npc;
        replicaIndex = 0;

        dialoguePanel.SetActive(true);
        NPCNameText.text = currentNPC.NPCName;
        dialogueText.text = currentNPC.NPCReplics[replicaIndex];
    }

    public void NextReplica()
    {
        if (currentNPC == null) return;

        replicaIndex++;

        if (replicaIndex >= currentNPC.NPCReplics.Length)
        {
            EndDialogue();
            return;
        }

        dialogueText.text = currentNPC.NPCReplics[replicaIndex];
    }

    public void EndDialogue()
    {
        dialoguePanel.SetActive(false);
        currentNPC = null;
    }
}
