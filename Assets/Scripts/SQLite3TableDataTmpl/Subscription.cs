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
    public enum SubscriptionEnum
    {
        ID,
        Price,
        SalePrice,
        SubscribeReward,
        LiveCd,
        LiveMax,
        UnlockRewardID,
        UnlockRewardNum,
        UnlockWeekID,
        UnlockWeekNum,
        AndroidCode,
        iOSCode,
        Max
    }

    public class Subscription : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)SubscriptionEnum.ID)]
        public int ID { get; private set; }  //序号

        [Sync((int)SubscriptionEnum.Price)]
        public float Price { get; set; }  //定价

        [Sync((int)SubscriptionEnum.SalePrice)]
        public float SalePrice { get; set; }  //折扣价

        [Sync((int)SubscriptionEnum.SubscribeReward)]
        public int SubscribeReward { get; set; }  //订阅奖励

        [Sync((int)SubscriptionEnum.LiveCd)]
        public float LiveCd { get; set; }  //体力冷却

        [Sync((int)SubscriptionEnum.LiveMax)]
        public int LiveMax { get; set; }  //体力上限

        [Sync((int)SubscriptionEnum.UnlockRewardID)]
        public int[] UnlockRewardID { get; set; }  //奖励道具ID

        [Sync((int)SubscriptionEnum.UnlockRewardNum)]
        public int[] UnlockRewardNum { get; set; }  //奖励道具数量

        [Sync((int)SubscriptionEnum.UnlockWeekID)]
        public int[] UnlockWeekID { get; set; }  //每周解锁道具ID

        [Sync((int)SubscriptionEnum.UnlockWeekNum)]
        public int[] UnlockWeekNum { get; set; }  //每周解锁道具数量

        [Sync((int)SubscriptionEnum.AndroidCode)]
        public string AndroidCode { get; set; }

        [Sync((int)SubscriptionEnum.iOSCode)]
        public string iOSCode { get; set; }

        public Subscription()
        {
        }

        public Subscription(int InID, float InPrice, float InSalePrice, int InSubscribeReward, float InLiveCd, int InLiveMax, int[] InUnlockRewardID, int[] InUnlockRewardNum, int[] InUnlockWeekID, int[] InUnlockWeekNum, string InAndroidCode, string IniOSCode)
        {
            ID = InID;
            Price = InPrice;
            SalePrice = InSalePrice;
            SubscribeReward = InSubscribeReward;
            LiveCd = InLiveCd;
            LiveMax = InLiveMax;
            UnlockRewardID = InUnlockRewardID;
            UnlockRewardNum = InUnlockRewardNum;
            UnlockWeekID = InUnlockWeekID;
            UnlockWeekNum = InUnlockWeekNum;
            AndroidCode = InAndroidCode;
            iOSCode = IniOSCode;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            string UnlockRewardIDLog = string.Empty;
            for (int i = 0; i < UnlockRewardID.Length; ++i)
            {
                UnlockRewardIDLog += UnlockRewardID[i] + ", ";
            }

            string UnlockRewardNumLog = string.Empty;
            for (int i = 0; i < UnlockRewardNum.Length; ++i)
            {
                UnlockRewardNumLog += UnlockRewardNum[i] + ", ";
            }

            string UnlockWeekIDLog = string.Empty;
            for (int i = 0; i < UnlockWeekID.Length; ++i)
            {
                UnlockWeekIDLog += UnlockWeekID[i] + ", ";
            }

            string UnlockWeekNumLog = string.Empty;
            for (int i = 0; i < UnlockWeekNum.Length; ++i)
            {
                UnlockWeekNumLog += UnlockWeekNum[i] + ", ";
            }

            return "Subscription : " + "\n    ID = " + ID + "\n    Price = " + Price + "\n    SalePrice = " + SalePrice + "\n    SubscribeReward = " + SubscribeReward + "\n    LiveCd = " + LiveCd + "\n    LiveMax = " + LiveMax + "\n    UnlockRewardID = " + UnlockRewardIDLog + "\n    UnlockRewardNum = " + UnlockRewardNumLog + "\n    UnlockWeekID = " + UnlockWeekIDLog + "\n    UnlockWeekNum = " + UnlockWeekNumLog + "\n    AndroidCode = " + AndroidCode + "\n    iOSCode = " + iOSCode;
        }

    }
}
