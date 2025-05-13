using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ExhibitionUI : MonoBehaviour
{
    public GameObject panel;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public Image artworkImage;

    public void DisplayArtwork(ArtworkData data)
    {
        if (panel.activeSelf)
            return;

        panel.SetActive(true);
        titleText.text = data.title;
        descriptionText.text = data.description;
        if (artworkImage != null && data.artworkImage != null)
        {
            artworkImage.sprite = data.artworkImage;
        }
    }

    public void HidePanel()
    {
        panel.SetActive(false);
    }
}
