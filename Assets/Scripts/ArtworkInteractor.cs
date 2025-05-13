using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ArtworkInteractor : MonoBehaviour
{
    public ArtworkData data;
    public ExhibitionUI ui;
    public AudioSource audioSource;

    private void Awake()
    {
        var interactable = GetComponent<XRGrabInteractable>();

        // XR 인터랙션에 반응하는 이벤트 등록
        interactable.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log("인터랙션!");

        if (ui != null && !ui.panel.activeSelf)
        {
            ui.DisplayArtwork(data);
        }

        if (data.voiceClip != null)
        {
            audioSource.clip = data.voiceClip;
            audioSource.Play();
        }
    }

    private void OnDestroy()
    {
        // 이벤트 해제 (메모리 누수 방지)
        GetComponent<XRGrabInteractable>().selectEntered.RemoveListener(OnSelectEntered);
    }
}
