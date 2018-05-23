using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpriteManager : MonoBehaviour {
	private Dictionary<string, UnityEvent> eventDictionary = new Dictionary<string, UnityEvent> ();

	/*void Init(){
		if (eventDictionary == null)
			eventDictionary = new Dictionary<string, UnityEvent> ();
	}*/

	// register a listener to the event manager
	public void StartListening(string eventName, UnityAction listener){
		UnityEvent thisEvent = null;
		if (eventDictionary.TryGetValue (eventName, out thisEvent))
			thisEvent.AddListener (listener);
		else {
			thisEvent = new UnityEvent ();
			thisEvent.AddListener (listener);
			eventDictionary.Add (eventName, thisEvent);
		}
	}

	// unregister a listener from the event manager
	public void StopListening (string eventName, UnityAction listener){
		UnityEvent thisEvent = null;
		if(eventDictionary.TryGetValue(eventName,out thisEvent))
			thisEvent.RemoveListener(listener);
	}

	// call to trigger the event
	public void TriggerEvent(string eventName){
		Debug.Log ("animation: " + eventName);
		UnityEvent thisEvent = null;
		if (eventDictionary.TryGetValue (eventName, out thisEvent))
			thisEvent.Invoke ();
	}
}
