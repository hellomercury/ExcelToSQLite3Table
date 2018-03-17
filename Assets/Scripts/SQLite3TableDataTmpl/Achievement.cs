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
    public enum AchievementEnum
    {
        AchvID,
        Name,
        Type,
        Icon,
        Des,
        Comment,
        Progress,
        RewardID,
        RewardNum,
        Max
    }

    public class Achievement : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)AchievementEnum.AchvID)]
        public int AchvID { get; private set; }

        [Sync((int)AchievementEnum.Name)]
        public string Name { get; set; }  //成就名称

        [Sync((int)AchievementEnum.Type)]
        public int Type { get; set; }  //成就类型

        [Sync((int)AchievementEnum.Icon)]
        public string Icon { get; set; }

        [Sync((int)AchievementEnum.Des)]
        public string Des { get; set; }  //成就描述

        [Sync((int)AchievementEnum.Comment)]
        public string Comment { get; set; }  //备注

        [Sync((int)AchievementEnum.Progress)]
        public int[] Progress { get; set; }  //进度

        [Sync((int)AchievementEnum.RewardID)]
        public int[][] RewardID { get; set; }  //奖励ID

        [Sync((int)AchievementEnum.RewardNum)]
        public int[][] RewardNum { get; set; }  //奖励数量

        public Achievement()
        {
        }

        public Achievement(int InAchvID, string InName, int InType, string InIcon, string InDes, string InComment, int[] InProgress, int[][] InRewardID, int[][] InRewardNum)
        {
            AchvID = InAchvID;
            Name = InName;
            Type = InType;
            Icon = InIcon;
            Des = InDes;
            Comment = InComment;
            Progress = InProgress;
            RewardID = InRewardID;
            RewardNum = InRewardNum;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            string ProgressLog = string.Empty;
            for (int i = 0; i < Progress.Length; ++i)
            {
                ProgressLog += Progress[i] + ", ";
            }

            string RewardIDLog = string.Empty;
            for (int i = 0; i < RewardID.Length; ++i)
            {
                RewardIDLog += "\n        ";                for (int j = 0; j < RewardID[i].Length; ++j)
                {
                    RewardIDLog += RewardID[i][j] + ", ";
                }
            }

            string RewardNumLog = string.Empty;
            for (int i = 0; i < RewardNum.Length; ++i)
            {
                RewardNumLog += "\n        ";                for (int j = 0; j < RewardNum[i].Length; ++j)
                {
                    RewardNumLog += RewardNum[i][j] + ", ";
                }
            }

            return "Achievement : " + "\n    AchvID = " + AchvID + "\n    Name = " + Name + "\n    Type = " + Type + "\n    Icon = " + Icon + "\n    Des = " + Des + "\n    Comment = " + Comment + "\n    Progress = " + ProgressLog + "\n    RewardID = " + RewardIDLog + "\n    RewardNum = " + RewardNumLog;
        }

    }
}
