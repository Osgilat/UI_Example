using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class MP3Player : MonoBehaviour {

    public AudioClip[] musicList;
    public Text uiText;

    private AudioSource audioSource;
    private int index = 0;
    private bool isStopByPlayer;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Play()
    {
        audioSource.Play();
        isStopByPlayer = false;
    }

    public void Pause()
    {
        audioSource.Pause();
        isStopByPlayer = true;
    }

    public void Stop()
    {
        audioSource.Stop();
        isStopByPlayer = true;
    }

    public void Next()
    {
        index++;
        if(index == musicList.Length)
        {
            index = 0;
        }

        audioSource.clip = musicList[index];
        Play();
    }

    public void Previous()
    {
        index--;
        if(index == -1)
        {
            index = musicList.Length - 1;
        }

        audioSource.clip = musicList[index];
        Play();
    }

    private void Update()
    {
        
        if(!audioSource.isPlaying && !isStopByPlayer)
        {
            Next();
        }

        if (audioSource.clip)
        {
            uiText.text = audioSource.clip.name;
        }
        
    }

}
