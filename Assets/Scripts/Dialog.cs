using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{

    [SerializeField]
    private Text DialogText;

    public void SetText(string text)
    {
        DialogText.text = "You Clicked " + text;
    }

    public void ClearText()
    {
        DialogText.text = "...";
    }
}
