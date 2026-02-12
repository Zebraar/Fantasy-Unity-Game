using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    
    public int[] Inv = new int[18];
    public Button[] invCells = new Button[18];
    public Sprite ID1texture;
    public Sprite DefTexture;

    public ScrollsLogic scrollsLogic;

    public void NewItem(int ItemID)
    {
        Debug.Log("Игрок подобрал предмет с ID " + ItemID);
        for(int index = 0; index < Inv.Length; index++)
        {
            if(Inv[index] == 0)
            {
                Inv[index] = ItemID;
                Debug.Log("Предмет с ID " + ItemID + "добавлен в слот " + index);               
                switch(ItemID)
                {
                    case 1:
                        invCells[index].GetComponent<Image>().sprite = ID1texture;
                        break;
                    default:
                        break;    
                }
                break;
            }
        }
    }

    public void UseItem(int index)
    {
        int ItemID = Inv[index];

        if(ItemID == 0)
        {
            Debug.Log("Слот пуст!");
            return;
        }

        Debug.Log("Используем предмет с ID " + ItemID);
        switch(ItemID)
        {
            case 1: //свиток с описанием долины
                scrollsLogic.Scroll("Долина Мудрости", "Это долина мудрости.Здесь много жителей.Они все обычно живут в мире.Иногда происходят мелкие ссоры, которые быстро решаются.");
                break;
            default:
                break;
        }
        // Inv[index] = 0;
        // invCells[index].GetComponent<Image>().sprite = DefTexture;
            
    }

}
