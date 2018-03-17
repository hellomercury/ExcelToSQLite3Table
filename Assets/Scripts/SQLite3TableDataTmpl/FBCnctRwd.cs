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
    public enum FBCnctRwdEnum
    {
        ID,
        RewardID,
        RewardNum,
        Max
    }

    public class FBCnctRwd : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)FBCnctRwdEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)FBCnctRwdEnum.RewardID)]
        public int[] RewardID { get; set; }

        [Sync((int)FBCnctRwdEnum.RewardNum)]
        public int[] RewardNum { get; set; }

        public FBCnctRwd()
        {
        }

        public FBCnctRwd(int InID, int[] InRewardID, int[] InRewardNum)
        {
            ID = InID;
            RewardID = InRewardID;
            RewardNum = InRewardNum;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            string RewardIDLog = string.Empty;
            for (int i = 0; i < RewardID.Length; ++i)
            {
                RewardIDLog += RewardID[i] + ", ";
            }

            string RewardNumLog = string.Empty;
            for (int i = 0; i < RewardNum.Length; ++i)
            {
                RewardNumLog += RewardNum[i] + ", ";
            }

            return "FBCnctRwd : " + "\n    ID = " + ID + "\n    RewardID = " + RewardIDLog + "\n    RewardNum = " + RewardNumLog;
        }

    }
}
