using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighting : MonoBehaviour {

    public static lighting lightingconditions;
    public string[] alllight = { "Sun light", "Bright light", "Dim light", "Darkness" };

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
        
	}
	
}
