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
    public enum BottomPropTriggerEnum
    {
        ID,
        UpCardCount,
        SubCardCount,
        Max
    }

    public class BottomPropTrigger : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)BottomPropTriggerEnum.ID)]
        public int ID { get; private set; }  //关卡ID

        [Sync((int)BottomPropTriggerEnum.UpCardCount)]
        public int UpCardCount { get; set; }  //桌面牌

        [Sync((int)BottomPropTriggerEnum.SubCardCount)]
        public int SubCardCount { get; set; }  //手牌

        public BottomPropTrigger()
        {
        }

        public BottomPropTrigger(int InID, int InUpCardCount, int InSubCardCount)
        {
            ID = InID;
            UpCardCount = InUpCardCount;
            SubCardCount = InSubCardCount;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "BottomPropTrigger : " + "\n    ID = " + ID + "\n    UpCardCount = " + UpCardCount + "\n    SubCardCount = " + SubCardCount;
        }

    }
}
