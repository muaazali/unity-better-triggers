using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public event System.Action<Collider> OnTriggerEntered;
    public event System.Action<Collider> OnTriggerExited;
    public event System.Action<Collider> OnTriggerStayed;

    public event System.Action<Collider2D> OnTriggerEntered2D;
    public event System.Action<Collider2D> OnTriggerExited2D;
    public event System.Action<Collider2D> OnTriggerStayed2D;

    [Tooltip("If empty, all tags are allowed.")]
    [SerializeField] private List<string> allowedTags = new();

    void OnTriggerEnter(Collider collider)
    {
        if (allowedTags.Count > 0 && !allowedTags.Contains(collider.tag)) return;
        OnTriggerEntered?.Invoke(collider);
    }

    void OnTriggerExit(Collider collider)
    {
        if (allowedTags.Count > 0 && !allowedTags.Contains(collider.tag)) return;
        OnTriggerExited?.Invoke(collider);
    }

    void OnTriggerStay(Collider collider)
    {
        if (allowedTags.Count > 0 && !allowedTags.Contains(collider.tag)) return;
        OnTriggerStayed?.Invoke(collider);
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (allowedTags.Count > 0 && !allowedTags.Contains(collider2D.tag)) return;
        OnTriggerEntered2D?.Invoke(collider2D);
    }

    void OnTriggerExit2D(Collider2D collider2D)
    {
        if (allowedTags.Count > 0 && !allowedTags.Contains(collider2D.tag)) return;
        OnTriggerExited2D?.Invoke(collider2D);
    }

    void OnTriggerStay2D(Collider2D collider2D)
    {
        if (allowedTags.Count > 0 && !allowedTags.Contains(collider2D.tag)) return;
        OnTriggerStayed2D?.Invoke(collider2D);
    }
}
