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
    public enum AdvertisingRuleEnum
    {
        ID,
        PlayAds,
        StageAdsTime,
        DayAdsTime,
        DayAds,
        StageAdsID,
        ContinuousAdsTime,
        SpacingTime,
        Max
    }

    public class AdvertisingRule : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)AdvertisingRuleEnum.ID)]
        public int ID { get; private set; }  //插屏规则类型

        [Sync((int)AdvertisingRuleEnum.PlayAds)]
        public int PlayAds { get; set; }  //是否插屏

        [Sync((int)AdvertisingRuleEnum.StageAdsTime)]
        public int StageAdsTime { get; set; }  //每关插屏上限

        [Sync((int)AdvertisingRuleEnum.DayAdsTime)]
        public int DayAdsTime { get; set; }  //每天插屏上限

        [Sync((int)AdvertisingRuleEnum.DayAds)]
        public int DayAds { get; set; }  //插屏时间

        [Sync((int)AdvertisingRuleEnum.StageAdsID)]
        public int StageAdsID { get; set; }  //解锁插屏关卡

        [Sync((int)AdvertisingRuleEnum.ContinuousAdsTime)]
        public int ContinuousAdsTime { get; set; }  //连续插屏次数

        [Sync((int)AdvertisingRuleEnum.SpacingTime)]
        public int SpacingTime { get; set; }  //插屏间隔

        public AdvertisingRule()
        {
        }

        public AdvertisingRule(int InID, int InPlayAds, int InStageAdsTime, int InDayAdsTime, int InDayAds, int InStageAdsID, int InContinuousAdsTime, int InSpacingTime)
        {
            ID = InID;
            PlayAds = InPlayAds;
            StageAdsTime = InStageAdsTime;
            DayAdsTime = InDayAdsTime;
            DayAds = InDayAds;
            StageAdsID = InStageAdsID;
            ContinuousAdsTime = InContinuousAdsTime;
            SpacingTime = InSpacingTime;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "AdvertisingRule : " + "\n    ID = " + ID + "\n    PlayAds = " + PlayAds + "\n    StageAdsTime = " + StageAdsTime + "\n    DayAdsTime = " + DayAdsTime + "\n    DayAds = " + DayAds + "\n    StageAdsID = " + StageAdsID + "\n    ContinuousAdsTime = " + ContinuousAdsTime + "\n    SpacingTime = " + SpacingTime;
        }

    }
}
