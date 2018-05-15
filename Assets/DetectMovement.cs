using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD;

public class DetectMovement : MonoBehaviour {

    private float oldXpos;
    private float oldYpos;
    public float sensitivity = 0.1f;
    public string trackname = "Drums";
    FMODUnity.StudioEventEmitter track1;
    public GameObject FX1;
    public GameObject FX2;
    public GameObject FX3;

    // Use this for initialization
    void Start () {
        oldXpos = transform.position.x;
        oldXpos = transform.position.y;
        var target = GameObject.Find(trackname);
        track1 = target.GetComponent<FMODUnity.StudioEventEmitter>();

        InvokeRepeating("CheckMovement", 2.0f, 0.1f);
	}
	
	// Update is called once per frame
	void CheckMovement () {

        float currentXpos = transform.position.x;
        float currentYpos = transform.position.y;
        float movementspeed = Mathf.Abs(oldXpos - currentXpos);
        float movementspeedY = Mathf.Abs(oldYpos - currentYpos);


        if ((movementspeed > sensitivity) || (movementspeedY > sensitivity))
        {
            //print("moving!");
            track1.SetParameter("VolIn", 1);
            FX1.SetActive(true);
            FX2.SetActive(true);
            FX3.SetActive(true);
        }
        else
        {
            track1.SetParameter("VolIn", 0);
            FX1.SetActive(false);
            FX2.SetActive(false);
            FX3.SetActive(false);

        }

        track1.SetParameter("Filter", (currentYpos - 0.5f));

        //print(currentYpos);

        oldXpos = currentXpos;
        oldYpos = currentYpos;
		
	}
}
