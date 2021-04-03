using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class AstronautCollision : MonoBehaviour
{
    [SerializeField] GameManager gm;

    private void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        gm.ast_total++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.ast_saved++;
        gameObject.SetActive(false);
        gm.AstroSaved();//ui

        if (gm.ast_saved == gm.ast_total)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }


    }
}
