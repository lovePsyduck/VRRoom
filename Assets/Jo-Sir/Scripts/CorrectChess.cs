using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectChess : MonoBehaviour
{
    [SerializeField] GameObject coloerCode;
    private void Awake()
    {
        coloerCode.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.name.Equals("CorrectPwan")) return;
        other.transform.SetParent(this.transform);
        other.transform.position = this.transform.position;
        // �̵� ��ȣ�ۿ�Ǯ���ֱ�
        Correct();
    }
    private void Correct()
    {
        coloerCode.SetActive(true);
    }
}
