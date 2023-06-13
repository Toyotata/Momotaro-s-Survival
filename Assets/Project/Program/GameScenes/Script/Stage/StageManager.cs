using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//タイルマップを操作する時に必要
using UnityEngine.Tilemaps;
//シーンの読み込み/再読み込み時に必要
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    [SerializeField] Tilemap tilemap;
    [SerializeField] Tile grassTile;

    //マップの最大数
    int i_max_x;
    int i_max_y;

    //マップの最小数
    int i_min_x;
    int i_min_y;

    void Start()
    {
        //マップの最大値設定
        i_max_x = 0;
        i_max_y = 0;

        //マップの最小値設定
        int i_min_x = 0;
        int i_min_y = 0;

        StartCoroutine(SetTile());
    }

    /// <summary>
    /// スタート時マップ作製処理
    /// </summary>
    /// <returns></returns>
    public IEnumerator SetTile()
    {
        ////マップをクリアする（重複しないようにする）
        tilemap.ClearAllTiles();
        for (int y = i_min_y-22; y < i_max_y+23; y++)
        {
            for (int x = i_min_x-50; x < i_max_x+28; x++)
            {
                tilemap.SetTile(new Vector3Int(x, y, 0), grassTile);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}