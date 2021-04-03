using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DestroyShip : MonoBehaviour
{
    PlayerActions pa;
    [SerializeField] GameObject BlackBackground;
    [SerializeField] GameObject AstColUI;
    [SerializeField] GameObject Button;

    private void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        pa = collision.gameObject.GetComponent<PlayerActions>();
        pa.isDead = true;
        BlackBackground.SetActive(true);
        AstColUI.SetActive(true);
    }
}
