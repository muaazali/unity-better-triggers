using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Trigger attackRangeTrigger;
    public Trigger interactionRangeTrigger;


    void Awake()
    {
        attackRangeTrigger.OnTriggerEntered += OnAttackRangeTriggerEntered;
        attackRangeTrigger.OnTriggerExited += OnAttackRangeTriggerExited;

        interactionRangeTrigger.OnTriggerEntered += OnInteractionRangeTriggerEntered;
        interactionRangeTrigger.OnTriggerExited += OnInteractionRangeTriggerExited;
    }

    void OnAttackRangeTriggerEntered(Collider collider)
    {
        Debug.Log("Hey, I entered the attack range! - says " + collider.name);
    }

    void OnAttackRangeTriggerExited(Collider collider)
    {
        Debug.Log("Hey, I exited the attack range! - says " + collider.name);
    }

    void OnInteractionRangeTriggerEntered(Collider collider)
    {
        Debug.Log("Hey, I entered the interaction range! - says " + collider.name);
    }

    void OnInteractionRangeTriggerExited(Collider collider)
    {
        Debug.Log("Hey, I exited the interaction range! - says " + collider.name);
    }
}
