using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//タイルマップを操作する時に必要
using UnityEngine.Tilemaps;
//シーンの読み込み/再読み込み時に必要　SceneManager.LoadScene("SampleScene");
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    [SerializeField] Tilemap tilemap;
    [SerializeField] Tile grassTile;

    void Start()
    {
        StartCoroutine(SetTile());
    }
    IEnumerator SetTile()
    {
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                tilemap.SetTile(new Vector3Int(x, y, 0), grassTile);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}