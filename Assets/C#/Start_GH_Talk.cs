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
            talk.text = "안녕 난 근호라고해 2반에 있지!";
            Talk.SetActive(true);
        }
        if(TalkCount == 2)
        {
            talk.text = "난 406호로 돌아가고싶어!";
        }
        if(TalkCount == 3)
        {
            talk.text = "난 보쿠노피코를 좋아하지 너도 보지 않을래?";
        }
        if(TalkCount == 4)
        {
            talk.text = "뭐? 게임을 시작하고싶은데 왠 자기소개냐고?";
        }
        if (TalkCount == 5)
        {
            talk.text = "음 바보야 오른쪽의 Start를 누르면 되잖아;;";
        }
        if (TalkCount == 6)
        {
            talk.text = "그럼 행운을 빌게!!";
        }
        if(TalkCount == 7)
        {
            Talk.SetActive (false);
        }
        if(TalkCount == 100)
        {
            talk.text = "아니 뭐 이걸 100번을 쳐 뭐라도 나올줄알았어?? 1000번 치면 인정해준다";
            Talk.SetActive(true);
        }
        if(TalkCount == 1000)
        {
            talk.text = "1000번을 치다니;; 넌 인정한다. 이거 쉽지 않을텐데 뻘짓이 대단하구나;;10만번 치면 선물을 줄게";
        }
        if (TalkCount == 100000)
        {
            talk.text = "여기까지 왔다고? 선물로 근호의 찐한 키스를 받을 권한이 생겼어 축하해!";
            Invoke("EndPlease", 10f);
        }
        if (TalkCount == 100100)
        {
            talk.text = "그만해 나 더이상 안해나 간다 잘있어라.";
            Invoke("ByeGH", 10f);
        }
    }

    void EndPlease()
    {
        talk.text = "여기가 끝이야 그만해 제발 진짜 안넣었어 진짜다 계속쳐봐 나오나 보자";
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
