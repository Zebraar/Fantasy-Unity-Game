using UnityEngine;

public class TriggersLogic : MonoBehaviour
{

    public NewDialogueSystem newDialogueSystem;
    public Dialogues fedaDialogues;
    public TargetsLogic targetsLogic;
    
    public void TriggerHandler(string triggerName)
    {
        switch(triggerName)
        {
            case "PlayerHelpKarl":
                newDialogueSystem.ShowDialogueTree("KarlWait");
                newDialogueSystem.EndDialogue();
                targetsLogic.CompleteTarget("TalkWithSomeone");
                targetsLogic.AddTarget("Поговори с Федей", "TalkWithFeda");
                break;
            case "PlayerDontHelpKarl":
                newDialogueSystem.ShowDialogueTree("KarlChoice1");
                newDialogueSystem.EndDialogue();
                break;  
            case "PlayerKnowkarlHistory":
                fedaDialogues.SetTree("FedaAfterKarlDialogue");
                break;    
        }
    }

}
