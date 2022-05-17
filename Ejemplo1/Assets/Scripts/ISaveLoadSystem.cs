using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISaveLoadSystem : MonoBehaviour
{
    public void SavePosition(GameObject player)
    {
        PlayerPrefs.SetFloat("position", player.transform.position.z);     
        PlayerPrefs.Save();
    }
}
