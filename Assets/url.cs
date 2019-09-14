using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class url : MonoBehaviour {
    public string web1;
	// Use this for initialization
	void Start () {
		
	}
    public void enlaceweb()
    {
        Application.OpenURL(web1);
    }
	
}
