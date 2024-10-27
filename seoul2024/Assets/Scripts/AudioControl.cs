using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    int state = 0; // 0은 소리가 꺼진 상태, 1은 플레이 상태

    public void SoundOnOff()
    {
        if (
            state == 1 //소리가 플레이 상태라면
        )
        {
            GameObject.Find("bgm").GetComponent<AudioSource>().Stop();
            state = 0;
        }
        else if (
            state == 0 // 소리가 멈춘 상태
        )
        {
            GameObject.Find("bgm").GetComponent<AudioSource>().Play();
            state = 1;
        }
    }

    public void PlayButtonSfx()
    {
        if ( GameObject.Find("sfx_click").GetComponent<AudioSource>().isPlaying ==true )
        {
            GameObject.Find("sfx_click").GetComponent<AudioSource>().Stop();
        }

        GameObject.Find("sfx_click").GetComponent<AudioSource>().Play();
    }

    public void PlayBgm()
    {
        if (
            GameObject.Find("bgm").GetComponent<AudioSource>().isPlaying ==
            false
        )
        {
            GameObject.Find("bgm").GetComponent<AudioSource>().Play();
        }
    }

    public void StopBgm()
    {
        if (GameObject.Find("bgm").GetComponent<AudioSource>().isPlaying == true
        )
        {
            GameObject.Find("bgm").GetComponent<AudioSource>().Stop();
        }
    }
}
