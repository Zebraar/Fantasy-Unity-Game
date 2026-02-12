using UnityEngine;
using UnityEngine.UI;

public class ScrollsLogic : MonoBehaviour
{
    
    public Text ScrollTitle;
    public Text ScrollText;
    public GameObject ScrollPanel;

    public void Scroll(string ScrollTitle, string ScrollText)
    {
        this.ScrollText.text = ScrollText;
        this.ScrollTitle.text = ScrollTitle;
        ScrollPanel.SetActive(true);
    }

    public void CloseScroll()
    {
        ScrollPanel.SetActive(false);
    }

}
