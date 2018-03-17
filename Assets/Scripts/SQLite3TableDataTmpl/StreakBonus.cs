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
    public enum StreakBonusEnum
    {
        ID,
        RewardType,
        RewardNum,
        RewardMin,
        RewardCorrection,
        StageTrigger,
        Streak,
        Correction,
        StreakLimited,
        Weight,
        WeightCorrection,
        WeightTrigger,
        WeightMin,
        Max
    }

    public class StreakBonus : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)StreakBonusEnum.ID)]
        public int ID { get; private set; }  //连击奖励ID

        [Sync((int)StreakBonusEnum.RewardType)]
        public int RewardType { get; set; }  //奖励类型

        [Sync((int)StreakBonusEnum.RewardNum)]
        public int RewardNum { get; set; }  //奖励数量

        [Sync((int)StreakBonusEnum.RewardMin)]
        public int RewardMin { get; set; }  //最低奖励数

        [Sync((int)StreakBonusEnum.RewardCorrection)]
        public int RewardCorrection { get; set; }  //奖励递减补正

        [Sync((int)StreakBonusEnum.StageTrigger)]
        public int StageTrigger { get; set; }  //递减触发次数

        [Sync((int)StreakBonusEnum.Streak)]
        public int Streak { get; set; }  //连击数

        [Sync((int)StreakBonusEnum.Correction)]
        public int Correction { get; set; }  //连击补正

        [Sync((int)StreakBonusEnum.StreakLimited)]
        public int StreakLimited { get; set; }  //连击数上限

        [Sync((int)StreakBonusEnum.Weight)]
        public int Weight { get; set; }  //权重

        [Sync((int)StreakBonusEnum.WeightCorrection)]
        public int WeightCorrection { get; set; }  //权重递减值

        [Sync((int)StreakBonusEnum.WeightTrigger)]
        public int WeightTrigger { get; set; }  //权重递减触发次数

        [Sync((int)StreakBonusEnum.WeightMin)]
        public int WeightMin { get; set; }  //权重最小值

        public StreakBonus()
        {
        }

        public StreakBonus(int InID, int InRewardType, int InRewardNum, int InRewardMin, int InRewardCorrection, int InStageTrigger, int InStreak, int InCorrection, int InStreakLimited, int InWeight, int InWeightCorrection, int InWeightTrigger, int InWeightMin)
        {
            ID = InID;
            RewardType = InRewardType;
            RewardNum = InRewardNum;
            RewardMin = InRewardMin;
            RewardCorrection = InRewardCorrection;
            StageTrigger = InStageTrigger;
            Streak = InStreak;
            Correction = InCorrection;
            StreakLimited = InStreakLimited;
            Weight = InWeight;
            WeightCorrection = InWeightCorrection;
            WeightTrigger = InWeightTrigger;
            WeightMin = InWeightMin;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "StreakBonus : " + "\n    ID = " + ID + "\n    RewardType = " + RewardType + "\n    RewardNum = " + RewardNum + "\n    RewardMin = " + RewardMin + "\n    RewardCorrection = " + RewardCorrection + "\n    StageTrigger = " + StageTrigger + "\n    Streak = " + Streak + "\n    Correction = " + Correction + "\n    StreakLimited = " + StreakLimited + "\n    Weight = " + Weight + "\n    WeightCorrection = " + WeightCorrection + "\n    WeightTrigger = " + WeightTrigger + "\n    WeightMin = " + WeightMin;
        }

    }
}
