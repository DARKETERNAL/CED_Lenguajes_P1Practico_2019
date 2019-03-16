using UnityEngine;
using UnityEngine.UI;

public class ChestUI : MonoBehaviour
{
    [SerializeField]
    private Text textfield;

    public void ShowText()
    {
        if (textfield != null)
        {
            textfield.text = "Press SPACE to open chest";
            textfield.gameObject.SetActive(true); 
        }
    }

    public void HideText()
    {
        if (textfield != null)
        {
            textfield.gameObject.SetActive(false); 
        }
    }

    private void Start()
    {
        HideText();
    }
}