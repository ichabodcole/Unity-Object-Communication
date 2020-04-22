using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearDialogDispatcher : MonoBehaviour
{

    [SerializeField]
    private AppEvent ClearDialogEvent;

    public void ClearDialog()
    {
        ClearDialogEvent.Dispatch();
    }
}
