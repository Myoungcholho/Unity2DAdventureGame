using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portaitArr;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(1000, new string[] { "�ȳ�?:0", "�� ���� ó�� �Ա���?:1" });
        talkData.Add(100, new string[] { "���� �������ھ�" });
        talkData.Add(200, new string[] { "���� �糪��� ��:0", "�� ȣ���� ������?:1" });

        portraitData.Add(200 + 0, portaitArr[0]);
        portraitData.Add(200 + 1, portaitArr[1]);
        portraitData.Add(200 + 2, portaitArr[2]);
        portraitData.Add(200 + 3, portaitArr[3]);


        portraitData.Add(1000 + 0, portaitArr[4]);
        portraitData.Add(1000 + 1, portaitArr[5]);
        portraitData.Add(1000 + 2, portaitArr[6]);
        portraitData.Add(1000 + 3, portaitArr[7]);




    }

    public string GetTalk(int ID, int talkIndex)
    {
        if(talkIndex == talkData[ID].Length)
        {
            return null;
        }
        else
            return talkData[ID][talkIndex];
    }

    public Sprite GetPortraite(int ID, int portaitIndex)
    {
        return portraitData[ID + portaitIndex];
    }
    

}
