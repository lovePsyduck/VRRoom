using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactionable : MonoBehaviour, IInteraction
{
    [SerializeField] private GameObject canvers;
    private Vector3 preVector3;
    public Vector3 PreVector3 { get { return preVector3; } }
    protected void Awake()
    {
        preVector3 = this.transform.position;
    }
    public virtual void Interaction()
    {
        this.gameObject.layer = 6;// ���̾� ��ȣ Ȯ�� �� �� ����
        canvers.SetActive(true);
        // ������Ʈ ��ġ ȭ�� �߾�����
        this.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0.5f);
        // �̻����϶� �÷��̾� ��ǲ �ٲ��ֱ�
    }

    public virtual void UnInteraction()
    {
        this.gameObject.layer = 0;// 0�� Default
        canvers.SetActive(false);
        this.transform.position = PreVector3;
    }
}
