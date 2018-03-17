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
    public enum LevelEnum
    {
        ID,
        Name,
        PreUnlockLevel,
        UnlockStarNum,
        SelectableTool,
        StarScore,
        CardRemoveBasePoint,
        StreakPointInterval,
        HandCardPoint,
        PointPerSecond,
        EnergyCost,
        UsableCardNum,
        BackupCardType,
        SpareCardNum,
        CountdownTime,
        ExtraCardNum,
        ExtraCardCost,
        CostInterval,
        CostThreshold,
        BackoutCost,
        BackoutCostInterval,
        BackoutCostThreshold,
        HandCardBombNum,
        BombRemoveCardNum,
        HandCardBombTime,
        JokerCardNum,
        ExtraGetCardNum,
        BGIMGResource,
        NewCardSpace,
        GoldReward,
        DynamicStartPoint,
        DynamicStartPsb,
        DynamicItem,
        DynamicItemPsb,
        DynamicItemTypeNum,
        DynamicItemTypeNumPsb,
        DynamicItemNum,
        DynamicItemNumPsb,
        ToolsForEventWeight,
        PokerStart,
        FailTriggerTime,
        PokerLibID,
        StreakBonus,
        Max
    }

    public class Level : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)LevelEnum.ID)]
        public int ID { get; private set; }  //关卡ID

        [Sync((int)LevelEnum.Name)]
        public string Name { get; set; }  //关卡名称

        [Sync((int)LevelEnum.PreUnlockLevel)]
        public int PreUnlockLevel { get; set; }  //前置解锁关卡

        [Sync((int)LevelEnum.UnlockStarNum)]
        public int UnlockStarNum { get; set; }  //解锁所需星级数量

        [Sync((int)LevelEnum.SelectableTool)]
        public int[] SelectableTool { get; set; }  //关卡内可选道具

        [Sync((int)LevelEnum.StarScore)]
        public int[] StarScore { get; set; }  //关卡内每个星级所需分数

        [Sync((int)LevelEnum.CardRemoveBasePoint)]
        public int CardRemoveBasePoint { get; set; }  //消除基础得分

        [Sync((int)LevelEnum.StreakPointInterval)]
        public int StreakPointInterval { get; set; }  //连续消除得分步进

        [Sync((int)LevelEnum.HandCardPoint)]
        public int HandCardPoint { get; set; }  //手牌得分

        [Sync((int)LevelEnum.PointPerSecond)]
        public int PointPerSecond { get; set; }  //时间得分

        [Sync((int)LevelEnum.EnergyCost)]
        public int EnergyCost { get; set; }  //关卡失败消耗体力数量

        [Sync((int)LevelEnum.UsableCardNum)]
        public int UsableCardNum { get; set; }  //待使用手牌手牌数量

        [Sync((int)LevelEnum.BackupCardType)]
        public int BackupCardType { get; set; }  //备用手牌类型

        [Sync((int)LevelEnum.SpareCardNum)]
        public int SpareCardNum { get; set; }  //备用手牌数量

        [Sync((int)LevelEnum.CountdownTime)]
        public int CountdownTime { get; set; }  //关卡倒计时

        [Sync((int)LevelEnum.ExtraCardNum)]
        public int ExtraCardNum { get; set; }  //单次购买额外手牌数量

        [Sync((int)LevelEnum.ExtraCardCost)]
        public int ExtraCardCost { get; set; }  //单次购买额外手牌基础花费

        [Sync((int)LevelEnum.CostInterval)]
        public int CostInterval { get; set; }  //购买额外手牌步进

        [Sync((int)LevelEnum.CostThreshold)]
        public int CostThreshold { get; set; }  //购买额外手牌花费阈值

        [Sync((int)LevelEnum.BackoutCost)]
        public int BackoutCost { get; set; }  //撤销基础花费

        [Sync((int)LevelEnum.BackoutCostInterval)]
        public int BackoutCostInterval { get; set; }  //撤销花费步进

        [Sync((int)LevelEnum.BackoutCostThreshold)]
        public int BackoutCostThreshold { get; set; }  //撤销花费阈值

        [Sync((int)LevelEnum.HandCardBombNum)]
        public int HandCardBombNum { get; set; }  //手牌炸弹数量

        [Sync((int)LevelEnum.BombRemoveCardNum)]
        public int BombRemoveCardNum { get; set; }  //炸弹炸掉卡牌数量

        [Sync((int)LevelEnum.HandCardBombTime)]
        public int HandCardBombTime { get; set; }  //单个手牌炸弹时间

        [Sync((int)LevelEnum.JokerCardNum)]
        public int JokerCardNum { get; set; }  //关卡内万能牌数量

        [Sync((int)LevelEnum.ExtraGetCardNum)]
        public int ExtraGetCardNum { get; set; }  //关卡内额外获取手牌卡牌数量

        [Sync((int)LevelEnum.BGIMGResource)]
        public string BGIMGResource { get; set; }  //背景资源

        [Sync((int)LevelEnum.NewCardSpace)]
        public bool NewCardSpace { get; set; }  //是否开启卡槽模式

        [Sync((int)LevelEnum.GoldReward)]
        public int GoldReward { get; set; }  //首次成功获得金币奖励

        [Sync((int)LevelEnum.DynamicStartPoint)]
        public int DynamicStartPoint { get; set; }  //动态调整起始次数

        [Sync((int)LevelEnum.DynamicStartPsb)]
        public float[] DynamicStartPsb { get; set; }  //动态调整起始概率

        [Sync((int)LevelEnum.DynamicItem)]
        public int[] DynamicItem { get; set; }  //动态调整随机物品

        [Sync((int)LevelEnum.DynamicItemPsb)]
        public float[] DynamicItemPsb { get; set; }  //动态调整随机物品种类概率

        [Sync((int)LevelEnum.DynamicItemTypeNum)]
        public int[] DynamicItemTypeNum { get; set; }  //动态调整随机物品种类数量

        [Sync((int)LevelEnum.DynamicItemTypeNumPsb)]
        public float[] DynamicItemTypeNumPsb { get; set; }  //动态调整随机物品种类数量概率

        [Sync((int)LevelEnum.DynamicItemNum)]
        public int[][] DynamicItemNum { get; set; }  //动态调整随机物品个数

        [Sync((int)LevelEnum.DynamicItemNumPsb)]
        public float[][] DynamicItemNumPsb { get; set; }  //动态调整随机物品个数概率

        [Sync((int)LevelEnum.ToolsForEventWeight)]
        public int ToolsForEventWeight { get; set; }  //event道具生成权重

        [Sync((int)LevelEnum.PokerStart)]
        public bool PokerStart { get; set; }  //动态初始调用

        [Sync((int)LevelEnum.FailTriggerTime)]
        public int FailTriggerTime { get; set; }  //触发失败次数

        [Sync((int)LevelEnum.PokerLibID)]
        public int PokerLibID { get; set; }  //牌组ID

        [Sync((int)LevelEnum.StreakBonus)]
        public int[] StreakBonus { get; set; }  //连击奖励ID

        public Level()
        {
        }

        public Level(int InID, string InName, int InPreUnlockLevel, int InUnlockStarNum, int[] InSelectableTool, int[] InStarScore, int InCardRemoveBasePoint, int InStreakPointInterval, int InHandCardPoint, int InPointPerSecond, int InEnergyCost, int InUsableCardNum, int InBackupCardType, int InSpareCardNum, int InCountdownTime, int InExtraCardNum, int InExtraCardCost, int InCostInterval, int InCostThreshold, int InBackoutCost, int InBackoutCostInterval, int InBackoutCostThreshold, int InHandCardBombNum, int InBombRemoveCardNum, int InHandCardBombTime, int InJokerCardNum, int InExtraGetCardNum, string InBGIMGResource, bool InNewCardSpace, int InGoldReward, int InDynamicStartPoint, float[] InDynamicStartPsb, int[] InDynamicItem, float[] InDynamicItemPsb, int[] InDynamicItemTypeNum, float[] InDynamicItemTypeNumPsb, int[][] InDynamicItemNum, float[][] InDynamicItemNumPsb, int InToolsForEventWeight, bool InPokerStart, int InFailTriggerTime, int InPokerLibID, int[] InStreakBonus)
        {
            ID = InID;
            Name = InName;
            PreUnlockLevel = InPreUnlockLevel;
            UnlockStarNum = InUnlockStarNum;
            SelectableTool = InSelectableTool;
            StarScore = InStarScore;
            CardRemoveBasePoint = InCardRemoveBasePoint;
            StreakPointInterval = InStreakPointInterval;
            HandCardPoint = InHandCardPoint;
            PointPerSecond = InPointPerSecond;
            EnergyCost = InEnergyCost;
            UsableCardNum = InUsableCardNum;
            BackupCardType = InBackupCardType;
            SpareCardNum = InSpareCardNum;
            CountdownTime = InCountdownTime;
            ExtraCardNum = InExtraCardNum;
            ExtraCardCost = InExtraCardCost;
            CostInterval = InCostInterval;
            CostThreshold = InCostThreshold;
            BackoutCost = InBackoutCost;
            BackoutCostInterval = InBackoutCostInterval;
            BackoutCostThreshold = InBackoutCostThreshold;
            HandCardBombNum = InHandCardBombNum;
            BombRemoveCardNum = InBombRemoveCardNum;
            HandCardBombTime = InHandCardBombTime;
            JokerCardNum = InJokerCardNum;
            ExtraGetCardNum = InExtraGetCardNum;
            BGIMGResource = InBGIMGResource;
            NewCardSpace = InNewCardSpace;
            GoldReward = InGoldReward;
            DynamicStartPoint = InDynamicStartPoint;
            DynamicStartPsb = InDynamicStartPsb;
            DynamicItem = InDynamicItem;
            DynamicItemPsb = InDynamicItemPsb;
            DynamicItemTypeNum = InDynamicItemTypeNum;
            DynamicItemTypeNumPsb = InDynamicItemTypeNumPsb;
            DynamicItemNum = InDynamicItemNum;
            DynamicItemNumPsb = InDynamicItemNumPsb;
            ToolsForEventWeight = InToolsForEventWeight;
            PokerStart = InPokerStart;
            FailTriggerTime = InFailTriggerTime;
            PokerLibID = InPokerLibID;
            StreakBonus = InStreakBonus;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            string SelectableToolLog = string.Empty;
            for (int i = 0; i < SelectableTool.Length; ++i)
            {
                SelectableToolLog += SelectableTool[i] + ", ";
            }

            string StarScoreLog = string.Empty;
            for (int i = 0; i < StarScore.Length; ++i)
            {
                StarScoreLog += StarScore[i] + ", ";
            }

            string DynamicStartPsbLog = string.Empty;
            for (int i = 0; i < DynamicStartPsb.Length; ++i)
            {
                DynamicStartPsbLog += DynamicStartPsb[i] + ", ";
            }

            string DynamicItemLog = string.Empty;
            for (int i = 0; i < DynamicItem.Length; ++i)
            {
                DynamicItemLog += DynamicItem[i] + ", ";
            }

            string DynamicItemPsbLog = string.Empty;
            for (int i = 0; i < DynamicItemPsb.Length; ++i)
            {
                DynamicItemPsbLog += DynamicItemPsb[i] + ", ";
            }

            string DynamicItemTypeNumLog = string.Empty;
            for (int i = 0; i < DynamicItemTypeNum.Length; ++i)
            {
                DynamicItemTypeNumLog += DynamicItemTypeNum[i] + ", ";
            }

            string DynamicItemTypeNumPsbLog = string.Empty;
            for (int i = 0; i < DynamicItemTypeNumPsb.Length; ++i)
            {
                DynamicItemTypeNumPsbLog += DynamicItemTypeNumPsb[i] + ", ";
            }

            string DynamicItemNumLog = string.Empty;
            for (int i = 0; i < DynamicItemNum.Length; ++i)
            {
                DynamicItemNumLog += "\n        ";                for (int j = 0; j < DynamicItemNum[i].Length; ++j)
                {
                    DynamicItemNumLog += DynamicItemNum[i][j] + ", ";
                }
            }

            string DynamicItemNumPsbLog = string.Empty;
            for (int i = 0; i < DynamicItemNumPsb.Length; ++i)
            {
                DynamicItemNumPsbLog += "\n        ";                for (int j = 0; j < DynamicItemNumPsb[i].Length; ++j)
                {
                    DynamicItemNumPsbLog += DynamicItemNumPsb[i][j] + ", ";
                }
            }

            string StreakBonusLog = string.Empty;
            for (int i = 0; i < StreakBonus.Length; ++i)
            {
                StreakBonusLog += StreakBonus[i] + ", ";
            }

            return "Level : " + "\n    ID = " + ID + "\n    Name = " + Name + "\n    PreUnlockLevel = " + PreUnlockLevel + "\n    UnlockStarNum = " + UnlockStarNum + "\n    SelectableTool = " + SelectableToolLog + "\n    StarScore = " + StarScoreLog + "\n    CardRemoveBasePoint = " + CardRemoveBasePoint + "\n    StreakPointInterval = " + StreakPointInterval + "\n    HandCardPoint = " + HandCardPoint + "\n    PointPerSecond = " + PointPerSecond + "\n    EnergyCost = " + EnergyCost + "\n    UsableCardNum = " + UsableCardNum + "\n    BackupCardType = " + BackupCardType + "\n    SpareCardNum = " + SpareCardNum + "\n    CountdownTime = " + CountdownTime + "\n    ExtraCardNum = " + ExtraCardNum + "\n    ExtraCardCost = " + ExtraCardCost + "\n    CostInterval = " + CostInterval + "\n    CostThreshold = " + CostThreshold + "\n    BackoutCost = " + BackoutCost + "\n    BackoutCostInterval = " + BackoutCostInterval + "\n    BackoutCostThreshold = " + BackoutCostThreshold + "\n    HandCardBombNum = " + HandCardBombNum + "\n    BombRemoveCardNum = " + BombRemoveCardNum + "\n    HandCardBombTime = " + HandCardBombTime + "\n    JokerCardNum = " + JokerCardNum + "\n    ExtraGetCardNum = " + ExtraGetCardNum + "\n    BGIMGResource = " + BGIMGResource + "\n    NewCardSpace = " + NewCardSpace + "\n    GoldReward = " + GoldReward + "\n    DynamicStartPoint = " + DynamicStartPoint + "\n    DynamicStartPsb = " + DynamicStartPsbLog + "\n    DynamicItem = " + DynamicItemLog + "\n    DynamicItemPsb = " + DynamicItemPsbLog + "\n    DynamicItemTypeNum = " + DynamicItemTypeNumLog + "\n    DynamicItemTypeNumPsb = " + DynamicItemTypeNumPsbLog + "\n    DynamicItemNum = " + DynamicItemNumLog + "\n    DynamicItemNumPsb = " + DynamicItemNumPsbLog + "\n    ToolsForEventWeight = " + ToolsForEventWeight + "\n    PokerStart = " + PokerStart + "\n    FailTriggerTime = " + FailTriggerTime + "\n    PokerLibID = " + PokerLibID + "\n    StreakBonus = " + StreakBonusLog;
        }

    }
}
