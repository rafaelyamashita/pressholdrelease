using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField]
    private GameObject _wall;

    [SerializeField]
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        GameObject Ground = Instantiate(_wall, new Vector2(0.71f, -2.75f), Quaternion.identity);
        
        Ground.gameObject.name = "Ground";

        Instantiate(_wall, new Vector2(6.6f, -10.06f), Quaternion.Euler(0,0,90f));
        Instantiate(_wall, new Vector2(3.36f, 12.14f), Quaternion.Euler(0,0,90f));
        
        GameObject Player = Instantiate(_player);

        Player.gameObject.name = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
