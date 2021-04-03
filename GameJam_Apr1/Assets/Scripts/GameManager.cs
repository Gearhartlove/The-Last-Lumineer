using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int ast_total = 0;
    public int ast_saved = 0;

    [SerializeField] Sprite vaccant;
    [SerializeField] Sprite saved;
    [SerializeField] Image[] astr_ui;

    private void Start()
    {
        Debug.Log("astronauttotal: " + ast_total);
        for (int i = 0; i < ast_total; i++)
        {
            astr_ui[i].gameObject.SetActive(true);
        }
    }

    public void AstroSaved()
    {
        astr_ui[ast_saved - 1].sprite = saved;
    }

}
