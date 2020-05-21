using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
	public GameObject playerCam;
    public GameObject cutsceneCam;

    // Start is called before the first frame update
    void Start()
    {
    	cutsceneCam.SetActive(true);
        playerCam.SetActive(false);
        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(6);
        cutsceneCam.SetActive(false);
        playerCam.SetActive(true);
    }
}
