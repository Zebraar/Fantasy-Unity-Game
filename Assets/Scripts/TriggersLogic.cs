using UnityEngine;

public class TriggersLogic : MonoBehaviour
{

    public NewDialogueSystem newDialogueSystem;
    
    public void TriggerHandler(string triggerName)
    {
        switch(triggerName)
        {
            case "PlayerHelpKarl":
                newDialogueSystem.ShowDialogueTree("KarlWait");
                newDialogueSystem.EndDialogue();
                break;
            case "PlayerDontHelpKarl":
                newDialogueSystem.ShowDialogueTree("KarlChoice1");
                newDialogueSystem.EndDialogue();
                break;  
        }
    }

}
