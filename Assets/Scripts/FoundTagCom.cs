using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundTagCom : MonoBehaviour
{

    private Dialog m_Dialog;

    // Start is called before the first frame update
    void Start()
    {
        m_Dialog = GameObject.FindGameObjectWithTag("Dialog").GetComponent<Dialog>();
    }

    public void SetDialogText(string text)
    {
        if(m_Dialog != null)
            m_Dialog.SetText(text);
    }
}
