using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public int minutos;
    public int segundos;
    public int pistas;
    public int contador;
    public int contadorpelotas;
    // Start is called before the first frame update
    void Start()
    {
        pistas = 0;
        contador = 0;
        contadorpelotas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(minutos == 0 && segundos == 0)
        {
            loadlose();
        }
        if(pistas == 2)
        {
            loadwin();
        }
        if (contador == 3)
        {
            pistas++;
            contador = 0;
        }
        if(contadorpelotas == 5)
        {
            pistas++;
            contadorpelotas = 0;
        }
    }
    private void loadwin()
    {
        SceneManager.LoadScene("Win");
    }

    private void loadlose()
    {
        SceneManager.LoadScene("Lose");
    }
}
