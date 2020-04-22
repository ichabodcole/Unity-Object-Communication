using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AppEvent : ScriptableObject
{
    private List<AppEventListener> listeners = new List<AppEventListener>();

    // Start is called before the first frame update
    public void Dispatch(string context = null)
    {
        Debug.Log("AppEvent: Dispatch ~ " + this.name.ToString());
        for(int i = listeners.Count -1; i >= 0; i--)
        {
            listeners[i].OnEventDispatched(context);
        }
    }

    public void AddListener(AppEventListener listener)
    {
        listeners.Add(listener);
    }

    public void RemoveListener(AppEventListener listener)
    {
        listeners.Remove(listener);
    }
}
