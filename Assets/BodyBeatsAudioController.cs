using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyBeatsAudioController : MonoBehaviour {

    public string trackname = "Drums";
    FMODUnity.StudioEventEmitter track1;

    public Transform user1;

    // Use this for initialization
    void Start () {
        var target = GameObject.Find(trackname);
        track1 = target.GetComponent<FMODUnity.StudioEventEmitter>();
    }
	
	// Update is called once per frame
	void Update () {
        if (user1.transform.position == new Vector3(0.0f, 0.0f, 0.0f)) {
            print("home");
        }
	}
}
