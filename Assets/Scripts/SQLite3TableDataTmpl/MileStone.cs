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
    public enum MileStoneEnum
    {
        ID,
        UnlockLevel,
        LotteryTime,
        LotteryLib,
        RewardNum,
        Weight,
        Max
    }

    public class MileStone : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)MileStoneEnum.ID)]
        public int ID { get; private set; }  //里程碑ID

        [Sync((int)MileStoneEnum.UnlockLevel)]
        public int UnlockLevel { get; set; }  //解锁关卡ID

        [Sync((int)MileStoneEnum.LotteryTime)]
        public int LotteryTime { get; set; }  //抽奖次数

        [Sync((int)MileStoneEnum.LotteryLib)]
        public int[] LotteryLib { get; set; }  //抽奖库

        [Sync((int)MileStoneEnum.RewardNum)]
        public int[] RewardNum { get; set; }  //奖品数量

        [Sync((int)MileStoneEnum.Weight)]
        public int[] Weight { get; set; }  //奖励权重

        public MileStone()
        {
        }

        public MileStone(int InID, int InUnlockLevel, int InLotteryTime, int[] InLotteryLib, int[] InRewardNum, int[] InWeight)
        {
            ID = InID;
            UnlockLevel = InUnlockLevel;
            LotteryTime = InLotteryTime;
            LotteryLib = InLotteryLib;
            RewardNum = InRewardNum;
            Weight = InWeight;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            string LotteryLibLog = string.Empty;
            for (int i = 0; i < LotteryLib.Length; ++i)
            {
                LotteryLibLog += LotteryLib[i] + ", ";
            }

            string RewardNumLog = string.Empty;
            for (int i = 0; i < RewardNum.Length; ++i)
            {
                RewardNumLog += RewardNum[i] + ", ";
            }

            string WeightLog = string.Empty;
            for (int i = 0; i < Weight.Length; ++i)
            {
                WeightLog += Weight[i] + ", ";
            }

            return "MileStone : " + "\n    ID = " + ID + "\n    UnlockLevel = " + UnlockLevel + "\n    LotteryTime = " + LotteryTime + "\n    LotteryLib = " + LotteryLibLog + "\n    RewardNum = " + RewardNumLog + "\n    Weight = " + WeightLog;
        }

    }
}
