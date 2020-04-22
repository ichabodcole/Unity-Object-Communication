using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HardReferenceCom : MonoBehaviour
{
    [SerializeField]
    private Dialog m_Dialog;

    public void SetDialogText(string text = "")
    {
        m_Dialog.SetText(text);
    }
}
