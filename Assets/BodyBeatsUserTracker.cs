using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyBeatsUserTracker : MonoBehaviour
{

    private KinectManager manager;
    private int numUsers = 0;

	// Use this for initialization
	void Start () {
        
        manager = KinectManager.Instance;

    }


    // Update is called once per frame
    void Update () {


        print(manager.GetBodyCount());
		
	}
}
