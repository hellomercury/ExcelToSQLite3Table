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
    public enum ItemBuyInfoEnum
    {
        ID,
        ItemNum,
        ItemActualNum,
        Price,
        ActualPrice,
        AndroidCode,
        iOSCode,
        BuyType,
        Max
    }

    public class ItemBuyInfo : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)ItemBuyInfoEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)ItemBuyInfoEnum.ItemNum)]
        public int ItemNum { get; set; }  //购买物品数量

        [Sync((int)ItemBuyInfoEnum.ItemActualNum)]
        public int ItemActualNum { get; set; }  //物品实际数量

        [Sync((int)ItemBuyInfoEnum.Price)]
        public float Price { get; set; }  //价格

        [Sync((int)ItemBuyInfoEnum.ActualPrice)]
        public float ActualPrice { get; set; }  //实际价格

        [Sync((int)ItemBuyInfoEnum.AndroidCode)]
        public string AndroidCode { get; set; }

        [Sync((int)ItemBuyInfoEnum.iOSCode)]
        public string iOSCode { get; set; }

        [Sync((int)ItemBuyInfoEnum.BuyType)]
        public int BuyType { get; set; }  //购买类型

        public ItemBuyInfo()
        {
        }

        public ItemBuyInfo(int InID, int InItemNum, int InItemActualNum, float InPrice, float InActualPrice, string InAndroidCode, string IniOSCode, int InBuyType)
        {
            ID = InID;
            ItemNum = InItemNum;
            ItemActualNum = InItemActualNum;
            Price = InPrice;
            ActualPrice = InActualPrice;
            AndroidCode = InAndroidCode;
            iOSCode = IniOSCode;
            BuyType = InBuyType;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "ItemBuyInfo : " + "\n    ID = " + ID + "\n    ItemNum = " + ItemNum + "\n    ItemActualNum = " + ItemActualNum + "\n    Price = " + Price + "\n    ActualPrice = " + ActualPrice + "\n    AndroidCode = " + AndroidCode + "\n    iOSCode = " + iOSCode + "\n    BuyType = " + BuyType;
        }

    }
}
