using System.Collections;
using System.Collections.Generic;
using Framework.SQLite3Helper;
using SQLite3TableDataTmpl;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        SQLite3Operate operate = SQLite3Factory.OpenToReadOnly("Database.db", false);
        Achievement[] achvList = operate.SelectArrayT<Achievement>();

        for (int i = 0; i < achvList.Length; ++i)
        {
            Debug.LogError(achvList[i]);
        }

        Achievement achv = new Achievement(0, "abc", 0, "1001", "defg", "hij",
                                           new int[] { 1, 2, 3 },
                                           new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } },
                                           new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } , new int[]{7, 8, 9}});
                                           //new int[][][] { new int[][] {new int[]{1, 2, 3}, new int[]{4, 5, 6} }, new int[][] { new int[]{7, 8, 9}, new int[]{10, 11, 12}} });
        Debug.LogError(achv);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
