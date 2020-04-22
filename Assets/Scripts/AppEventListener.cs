using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AppEventListener : MonoBehaviour
{

    [SerializeField]
    private AppEvent m_AppEvent;

    [SerializeField]
    private StringContextEvent Response;

    private void OnEnable()
    {
        m_AppEvent.AddListener(this);
    }

    private void OnDisable()
    {
        m_AppEvent.RemoveListener(this);
    }

    public void OnEventDispatched(string context = "")
    {
        Response.Invoke(context);
    }


}
