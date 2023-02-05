using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats_jugador : MonoBehaviour
{
    public int etapa_raiz;
    public int etapa_hojas;

    public GameObject top, bot;
    private SpriteRenderer rend_top;
    private SpriteRenderer rend_bot;
    private Sprite sprite_raiz, sprite_hojas;

    public void nacer(int raiz, int hojas)
    {
        rend_top = top.GetComponent<SpriteRenderer>();
        rend_bot = bot.GetComponent<SpriteRenderer>();
        switch(raiz) 
        {
            case 1:
            sprite_raiz = Resources.Load<Sprite>("raiz_1");
            break;

            case 2:
            sprite_raiz = Resources.Load<Sprite>("raiz_2");
            break;

            default:
            sprite_raiz = Resources.Load<Sprite>("raiz_1");
            break;
        }
        rend_top.sprite = sprite_raiz;
        switch(hojas) 
        {
            case 1:
            sprite_hojas = Resources.Load<Sprite>("hojas_1");
            break;

            case 2:
            sprite_hojas = Resources.Load<Sprite>("hojas_2");
            break;
            
            default:
            sprite_hojas = Resources.Load<Sprite>("hojas_1");
            break;
        }
        rend_bot.sprite = sprite_hojas;
    }
}
