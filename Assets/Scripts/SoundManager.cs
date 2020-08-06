﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip clip;
}

public class SoundManager : MonoBehaviour
{
    [Header("사운드 등록")]
    [SerializeField] Sound[] bgmSounds;

    [Header("BGM 플레이어")]
    [SerializeField] AudioSource bgmPlayer;

    // Start is called before the first frame update
    void Start()
    {
        PlayRandomBGM();
    }

    public void PlayRandomBGM()
    {
        int random = Random.Range(0, 1);
        bgmPlayer.clip = bgmSounds[random].clip;
        bgmPlayer.Play();
    }
}
