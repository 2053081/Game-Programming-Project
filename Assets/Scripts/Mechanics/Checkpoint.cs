using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private bool isActivated = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isActivated) return;
        if (other.CompareTag("Player"))
        {
            isActivated = true;
            SaveLoadManager.Instance.SetCheckpoint(transform.position);
        }
    }
}
