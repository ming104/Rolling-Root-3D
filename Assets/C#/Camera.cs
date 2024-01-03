using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player; // �ٶ� �÷��̾� ������Ʈ�Դϴ�.
    public float xmove = 0;  // X�� ���� �̵���
    public float ymove = 0;  // Y�� ���� �̵���
    public float distance = 5;
    public float speed = 10f;
    //public GameObject PausePanel;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        xmove += Input.GetAxis("Mouse X"); // ���콺�� �¿� �̵����� xmove �� �����մϴ�.
        ymove -= Input.GetAxis("Mouse Y"); // ���콺�� ���� �̵����� ymove �� �����մϴ�.
        transform.rotation = Quaternion.Euler(ymove, xmove, 0); // �̵����� ���� ī�޶��� �ٶ󺸴� ������ �����մϴ�.
        Vector3 reverseDistance = new Vector3(0.0f, 0.0f, distance); // ī�޶� �ٶ󺸴� �չ����� Z ���Դϴ�. �̵����� ���� Z ������� ���͸� ���մϴ�.
        transform.position = player.transform.position - transform.rotation * reverseDistance; // �÷��̾��� ��ġ���� ī�޶� �ٶ󺸴� ���⿡ ���Ͱ��� ������ ��� ��ǥ�� �����մϴ�.
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (distance > 3)
            {
                distance--;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (distance < 20)
            {
                distance++;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //PausePanel.SetActive(true);
        }
    }
}