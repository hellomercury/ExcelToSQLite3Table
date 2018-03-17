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
    public enum ChristmasEventEnum
    {
        ID,
        ToolID,
        Planet,
        ResetToolNum,
        ResetCostCur,
        ResetCost,
        NeedToolNum,
        RewardType,
        RewardID,
        RewardNum,
        Max
    }

    public class ChristmasEvent : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)ChristmasEventEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)ChristmasEventEnum.ToolID)]
        public int ToolID { get; set; }

        [Sync((int)ChristmasEventEnum.Planet)]
        public int Planet { get; set; }

        [Sync((int)ChristmasEventEnum.ResetToolNum)]
        public int ResetToolNum { get; set; }

        [Sync((int)ChristmasEventEnum.ResetCostCur)]
        public int ResetCostCur { get; set; }

        [Sync((int)ChristmasEventEnum.ResetCost)]
        public int ResetCost { get; set; }

        [Sync((int)ChristmasEventEnum.NeedToolNum)]
        public int NeedToolNum { get; set; }

        [Sync((int)ChristmasEventEnum.RewardType)]
        public int RewardType { get; set; }

        [Sync((int)ChristmasEventEnum.RewardID)]
        public int[] RewardID { get; set; }

        [Sync((int)ChristmasEventEnum.RewardNum)]
        public int[] RewardNum { get; set; }

        public ChristmasEvent()
        {
        }

        public ChristmasEvent(int InID, int InToolID, int InPlanet, int InResetToolNum, int InResetCostCur, int InResetCost, int InNeedToolNum, int InRewardType, int[] InRewardID, int[] InRewardNum)
        {
            ID = InID;
            ToolID = InToolID;
            Planet = InPlanet;
            ResetToolNum = InResetToolNum;
            ResetCostCur = InResetCostCur;
            ResetCost = InResetCost;
            NeedToolNum = InNeedToolNum;
            RewardType = InRewardType;
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

            return "ChristmasEvent : " + "\n    ID = " + ID + "\n    ToolID = " + ToolID + "\n    Planet = " + Planet + "\n    ResetToolNum = " + ResetToolNum + "\n    ResetCostCur = " + ResetCostCur + "\n    ResetCost = " + ResetCost + "\n    NeedToolNum = " + NeedToolNum + "\n    RewardType = " + RewardType + "\n    RewardID = " + RewardIDLog + "\n    RewardNum = " + RewardNumLog;
        }

    }
}
