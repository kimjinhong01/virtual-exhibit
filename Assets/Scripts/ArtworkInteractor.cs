using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtworkInteractor : MonoBehaviour
{
    public ArtworkData data;
    public ExhibitionUI ui;
    public AudioSource audioSource;

    private void OnMouseDown()
    {
        ui.DisplayArtwork(data);
        if (data.voiceClip != null)
        {
            audioSource.clip = data.voiceClip;
            audioSource.Play();
        }
    }
}
