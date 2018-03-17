/*
 * --->SQLite3 dataSyncBase table structure.<---
 * --->This class code is automatically generated。<---
 * --->If you need to modify, please place the custom code between <Self Code Begin> and <Self Code End>.
 *                                                                                    --szn
 */

using Framework.SQLite3Helper;
using Framework.Sync;


namespace SQLite3TableDataTmpl
{
    public enum LevelLibEnum
    {
        ID,
        PokerGroup,
        Max
    }

    public class LevelLib : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)LevelLibEnum.ID)]
        public int ID { get; private set; }  //ID

        [Sync((int)LevelLibEnum.PokerGroup)]
        public int[] PokerGroup { get; set; }  //牌组

        public LevelLib()
        {
        }

        public LevelLib(int InID, int[] InPokerGroup)
        {
            ID = InID;
            PokerGroup = InPokerGroup;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            string PokerGroupLog = string.Empty;
            for (int i = 0; i < PokerGroup.Length; ++i)
            {
                PokerGroupLog += PokerGroup[i] + ", ";
            }

            return "LevelLib : " + "\n    ID = " + ID + "\n    PokerGroup = " + PokerGroupLog;
        }

    }
}
