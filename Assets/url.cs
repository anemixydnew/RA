using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class url : MonoBehaviour {
    public string web1;
    public string web2;
    public string web3;
    // Use this for initialization
    void Start () {
		
	}
    public void enlaceweb()
    {
        int x = Random.Range(1, 4);
        if (x == 2)
        {
            Application.OpenURL(web1);
        }
        else if(x==3)
        {
            Application.OpenURL(web2);
        }
        else
        {
            Application.OpenURL(web3);
        }
    }
	
}
