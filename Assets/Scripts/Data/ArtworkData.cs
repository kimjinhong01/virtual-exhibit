using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ArtworkData", menuName = "Exhibition/Artwork")]
public class ArtworkData : ScriptableObject
{
    public string title;
    public string description;
    public AudioClip voiceClip;
    public Sprite artworkImage;
}
