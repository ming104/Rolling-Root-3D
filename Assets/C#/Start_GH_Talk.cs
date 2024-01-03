using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_GH_Talk : MonoBehaviour
{
    public int TalkCount;
    public GameObject Talk;
    public Text talk;
    // Start is called before the first frame update
    void Start()
    {
        TalkCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(TalkCount == 0)
        {
            Talk.SetActive(false);
        }
        if(TalkCount == 1)
        {
            talk.text = "�ȳ� �� ��ȣ����� 2�ݿ� ����!";
            Talk.SetActive(true);
        }
        if(TalkCount == 2)
        {
            talk.text = "�� 406ȣ�� ���ư���;�!";
        }
        if(TalkCount == 3)
        {
            talk.text = "�� ��������ڸ� �������� �ʵ� ���� ������?";
        }
        if(TalkCount == 4)
        {
            talk.text = "��? ������ �����ϰ������ �� �ڱ�Ұ��İ�?";
        }
        if (TalkCount == 5)
        {
            talk.text = "�� �ٺ��� �������� Start�� ������ ���ݾ�;;";
        }
        if (TalkCount == 6)
        {
            talk.text = "�׷� ����� ����!!";
        }
        if(TalkCount == 7)
        {
            Talk.SetActive (false);
        }
        if(TalkCount == 100)
        {
            talk.text = "�ƴ� �� �̰� 100���� �� ���� �����پ˾Ҿ�?? 1000�� ġ�� �������ش�";
            Talk.SetActive(true);
        }
        if(TalkCount == 1000)
        {
            talk.text = "1000���� ġ�ٴ�;; �� �����Ѵ�. �̰� ���� �����ٵ� ������ ����ϱ���;;10���� ġ�� ������ �ٰ�";
        }
        if (TalkCount == 100000)
        {
            talk.text = "������� �Դٰ�? ������ ��ȣ�� ���� Ű���� ���� ������ ����� ������!";
            Invoke("EndPlease", 10f);
        }
        if (TalkCount == 100100)
        {
            talk.text = "�׸��� �� ���̻� ���س� ���� ���־��.";
            Invoke("ByeGH", 10f);
        }
    }

    void EndPlease()
    {
        talk.text = "���Ⱑ ���̾� �׸��� ���� ��¥ �ȳ־��� ��¥�� ����ĺ� ������ ����";
    }

    void ByeGH()
    {
        Talk.SetActive(false);
    }

    public void Click()
    {
        TalkCount++;
    }
}
