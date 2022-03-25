using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(Collider))]
[DisallowMultipleComponent]
[AddComponentMenu("Lerning/Tool/Attributes")]
[SelectionBase]
[HelpURL("https://vk.com/evilcreator31")]

public class Attributes : MonoBehaviour
{
    [Header("Power")]
    [SerializeField] private float powerClick;
    [Space(5f)]
    [SerializeField] private float powerShot;
    [TextArea(2,5)]
    [Multiline(5)]
    [SerializeField] private string name;
    [HideInInspector]
    public float deadTime;
    [Range(0, 1)]
    [SerializeField] private float speed;
    [Tooltip("No click bro...")]
    [SerializeField] private bool isJumping;
    [Delayed]
    [SerializeField] private Vector3 newPos;
    
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    public static void Lerning()
    {
        Debug.Log("Helloy Word");
    }
}
