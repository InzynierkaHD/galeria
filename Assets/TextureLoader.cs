using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.Threading;

public class TextureLoader : MonoBehaviour {

    public string url = "http://dami94.2ap.pl/hipertrofia.jpg";

    // Use this for initialization
    IEnumerator Start () {

        // Start a download of the given URL
        WWW www = new WWW(url);

        // Wait for download to complete
        yield return www;

        // assign texture
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = www.texture;

     
    }

    private IEnumerator waitForDownload() {
        yield return new WaitForSeconds(0.1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
