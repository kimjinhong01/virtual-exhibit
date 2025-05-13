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

        // XR ���ͷ��ǿ� �����ϴ� �̺�Ʈ ���
        interactable.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log("���ͷ���!");

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
        // �̺�Ʈ ���� (�޸� ���� ����)
        GetComponent<XRGrabInteractable>().selectEntered.RemoveListener(OnSelectEntered);
    }
}
