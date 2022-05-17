using UnityEngine;
using UnityEngine.Events;

public class Checkpoints : MonoBehaviour
{
    public UnityEvent event1;

    private void OnTriggerEnter(Collider o)
    {
        if (o.CompareTag("Player"))
        {
            event1?.Invoke();
        }
    }
}
