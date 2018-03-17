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
    public enum ItemUnlockInfoEnum
    {
        ID,
        UnlockType,
        NeedItemID,
        NeedINum,
        ActualNeedNum,
        UnlockItemNum,
        Type,
        Max
    }

    public class ItemUnlockInfo : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)ItemUnlockInfoEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)ItemUnlockInfoEnum.UnlockType)]
        public int UnlockType { get; set; }  //解锁类型

        [Sync((int)ItemUnlockInfoEnum.NeedItemID)]
        public int NeedItemID { get; set; }  //所需物品ID

        [Sync((int)ItemUnlockInfoEnum.NeedINum)]
        public int NeedINum { get; set; }  //所需物数量

        [Sync((int)ItemUnlockInfoEnum.ActualNeedNum)]
        public int ActualNeedNum { get; set; }  //实际所需数量

        [Sync((int)ItemUnlockInfoEnum.UnlockItemNum)]
        public int UnlockItemNum { get; set; }  //解锁物品数量

        [Sync((int)ItemUnlockInfoEnum.Type)]
        public int Type { get; set; }

        public ItemUnlockInfo()
        {
        }

        public ItemUnlockInfo(int InID, int InUnlockType, int InNeedItemID, int InNeedINum, int InActualNeedNum, int InUnlockItemNum, int InType)
        {
            ID = InID;
            UnlockType = InUnlockType;
            NeedItemID = InNeedItemID;
            NeedINum = InNeedINum;
            ActualNeedNum = InActualNeedNum;
            UnlockItemNum = InUnlockItemNum;
            Type = InType;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "ItemUnlockInfo : " + "\n    ID = " + ID + "\n    UnlockType = " + UnlockType + "\n    NeedItemID = " + NeedItemID + "\n    NeedINum = " + NeedINum + "\n    ActualNeedNum = " + ActualNeedNum + "\n    UnlockItemNum = " + UnlockItemNum + "\n    Type = " + Type;
        }

    }
}
