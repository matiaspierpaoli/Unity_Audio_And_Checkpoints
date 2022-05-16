using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    private void OnTriggerEnter(Collider o)
    {
        if (o.CompareTag("Player"))
        {          
            PlayerPrefs.SetFloat("position", o.transform.position.z);
            PlayerPrefs.Save();
        }
    }
}
