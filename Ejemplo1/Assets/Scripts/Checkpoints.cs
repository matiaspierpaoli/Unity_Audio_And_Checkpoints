using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    int savePozZ = -19;
    const string checkpointKey = "Checkpoint";

    private void Start()
    {
        savePozZ = PlayerPrefs.GetInt(checkpointKey, -19);
        transform.position = new Vector3(transform.position.x, transform.position.y, savePozZ);
    }


    private void OnTriggerEnter(Collider o)
    {
        if (o.CompareTag("Player"))
        {
            savePozZ = (int)o.transform.position.z;

            PlayerPrefs.SetInt(checkpointKey, savePozZ);
            PlayerPrefs.Save();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayerPrefs.SetInt(checkpointKey, -19);
            PlayerPrefs.Save();
        }
    }
}
