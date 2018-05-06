using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD;

public class DetectMovement : MonoBehaviour {

    private float oldXpos;
    public float sensitivity = 0.1f;
    public string trackname = "Drums";
    FMODUnity.StudioEventEmitter track1;

	// Use this for initialization
	void Start () {
        oldXpos = transform.position.x;
        var target = GameObject.Find(trackname);
        track1 = target.GetComponent<FMODUnity.StudioEventEmitter>();

        InvokeRepeating("CheckMovement", 2.0f, 0.5f);
	}
	
	// Update is called once per frame
	void CheckMovement () {

        float currentXpos = transform.position.x;
        float currentYpos = transform.position.y;
        float movementspeed = Mathf.Abs(oldXpos - currentXpos);


        if (movementspeed > sensitivity)
        {
            //print("moving!");
            track1.SetParameter("VolIn", 1);
        }
        else track1.SetParameter("VolIn", 0);

        track1.SetParameter("Filter", (currentYpos - 0.5f));

        //print(currentYpos);

        oldXpos = currentXpos;
		
	}
}
