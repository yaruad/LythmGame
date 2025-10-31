using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartManager : MonoBehaviour
{
    public AudioSource playerAudio;

    [SerializeField]
    private AudioClip[] selectAudioClips;

    [SerializeField]
    private int SelectNum;

    [SerializeField]
    private Slider volumeSlider;

    [SerializeField]
    private GameObject[] MusicSelects;

    public static string MusicName;
    public static int MusicNum;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerAudio.PlayOneShot(selectAudioClips[MusicNum]);
    }


    void Update()
    {
        
    }

    public void MusicBtn(string BtnName)
    {
        if (BtnName == "Next")
        {
            if (SelectNum < MusicSelects.Length - 1)
            {
                playerAudio.Stop();
                MusicSelects[SelectNum].SetActive(false);
                SelectNum++;
                MusicSelects[SelectNum].SetActive(true);
                playerAudio.PlayOneShot(selectAudioClips[SelectNum]);
            }
        }
        else
        {
            if (SelectNum > 0)
            {
                playerAudio.Stop();
                MusicSelects[SelectNum].SetActive(false);
                SelectNum--;
                MusicSelects[SelectNum].SetActive(true);
                playerAudio.PlayOneShot(selectAudioClips[SelectNum]);
            }
        }
    }
}
