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
    public enum PlayerNameCostEnum
    {
        ID,
        Cost,
        Interval,
        LimitThreshold,
        Max
    }

    public class PlayerNameCost : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)PlayerNameCostEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)PlayerNameCostEnum.Cost)]
        public int Cost { get; set; }  //改名金币花费

        [Sync((int)PlayerNameCostEnum.Interval)]
        public int Interval { get; set; }  //花费递进步长

        [Sync((int)PlayerNameCostEnum.LimitThreshold)]
        public int LimitThreshold { get; set; }  //花费阈值

        public PlayerNameCost()
        {
        }

        public PlayerNameCost(int InID, int InCost, int InInterval, int InLimitThreshold)
        {
            ID = InID;
            Cost = InCost;
            Interval = InInterval;
            LimitThreshold = InLimitThreshold;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "PlayerNameCost : " + "\n    ID = " + ID + "\n    Cost = " + Cost + "\n    Interval = " + Interval + "\n    LimitThreshold = " + LimitThreshold;
        }

    }
}
