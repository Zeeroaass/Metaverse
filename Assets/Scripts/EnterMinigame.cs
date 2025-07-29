using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMinigame : MonoBehaviour
{
    public GameObject UI;

    private void OnTriggerEnter2D(Collider2D other) //������ ���ö�
    {
        if (other.CompareTag("Player"))
        {
            UI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) //�������� ������ �ݰ����ϴ�
    {
        if (other.CompareTag("Player"))
        {
            UI.SetActive(false);
        }
    }
}
