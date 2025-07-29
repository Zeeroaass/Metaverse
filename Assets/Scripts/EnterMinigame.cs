using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMinigame : MonoBehaviour
{
    public GameObject UI;

    private void OnTriggerEnter2D(Collider2D other) //영역에 들어올때
    {
        if (other.CompareTag("Player"))
        {
            UI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) //영역에서 나갈때 반갑습니다
    {
        if (other.CompareTag("Player"))
        {
            UI.SetActive(false);
        }
    }
}
