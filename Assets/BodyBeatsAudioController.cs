using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyBeatsAudioController : MonoBehaviour {

    public string trackname1 = "Drums";
    public string trackname2 = "Bass";
    public string trackname3 = "Chords";
    public string trackname4 = "Strings";

    FMODUnity.StudioEventEmitter track1;
    FMODUnity.StudioEventEmitter track2;
    FMODUnity.StudioEventEmitter track3;
    FMODUnity.StudioEventEmitter track4;

    public Transform user1;
    public Transform user2;
    public Transform user3;
    public Transform user4;

    // Use this for initialization
    void Start () {
        var target1 = GameObject.Find(trackname1);
        var target2 = GameObject.Find(trackname2);
        var target3 = GameObject.Find(trackname3);
        var target4 = GameObject.Find(trackname4);

        track1 = target1.GetComponent<FMODUnity.StudioEventEmitter>();
        track2 = target2.GetComponent<FMODUnity.StudioEventEmitter>();
        track3 = target3.GetComponent<FMODUnity.StudioEventEmitter>();
        track4 = target4.GetComponent<FMODUnity.StudioEventEmitter>();
    }
	
	// Update is called once per frame
	void Update () {

        //choose random number
       int newTrackNumber = Random.Range(1, 3);


        //check if users pos = 0
        if ((user1.transform.position == new Vector3(0.0f, 0.0f, 0.0f)) &&
            (user2.transform.position == new Vector3(0.0f, 0.0f, 0.0f)) &&
            (user3.transform.position == new Vector3(0.0f, 0.0f, 0.0f)) &&
            (user4.transform.position == new Vector3(0.0f, 0.0f, 0.0f))) {
             print("home");
            //switch tracks
            switch (newTrackNumber)
            {
                case 1:
                    track1.SetParameter("TrackA", 0);
                    track2.SetParameter("TrackA", 0);
                    track3.SetParameter("TrackA", 0);
                    track4.SetParameter("TrackA", 0);
                    break;
                case 2:
                    track1.SetParameter("TrackA", 1);
                    track2.SetParameter("TrackA", 1);
                    track3.SetParameter("TrackA", 1);
                    track4.SetParameter("TrackA", 1);
                    break;
            }

            
        }
	}
}
