using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCall : MonoBehaviour
{
    [SerializeField]
    private BGMName SetBgm;
    void Start()
    {
        AudioManager.Instance.PlayBGM(SetBgm);
    }
    /*void OnDestroy()
    {
        AudioManager.Instance.StopBGM();
    }*/
}
