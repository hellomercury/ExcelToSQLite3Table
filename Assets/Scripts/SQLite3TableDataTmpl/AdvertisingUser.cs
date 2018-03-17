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
    public enum AdvertisingUserEnum
    {
        ID,
        Pay,
        TotalPayMin,
        TotalPayMax,
        LoginDays,
        LoginProportion,
        LastPaid,
        PaidFrequency,
        DayCostGold,
        ContinuousLogin,
        TotalLogin,
        StageCostGold,
        RuleID,
        Max
    }

    public class AdvertisingUser : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)AdvertisingUserEnum.ID)]
        public int ID { get; private set; }  //用户类型

        [Sync((int)AdvertisingUserEnum.Pay)]
        public bool Pay { get; set; }  //是否付费

        [Sync((int)AdvertisingUserEnum.TotalPayMin)]
        public int TotalPayMin { get; set; }  //最低付费总额度

        [Sync((int)AdvertisingUserEnum.TotalPayMax)]
        public int TotalPayMax { get; set; }  //最高付费总额度

        [Sync((int)AdvertisingUserEnum.LoginDays)]
        public int[] LoginDays { get; set; }  //用户注册天数

        [Sync((int)AdvertisingUserEnum.LoginProportion)]
        public int[] LoginProportion { get; set; }  //用户登录比重

        [Sync((int)AdvertisingUserEnum.LastPaid)]
        public int LastPaid { get; set; }  //上次付费距今天数

        [Sync((int)AdvertisingUserEnum.PaidFrequency)]
        public float PaidFrequency { get; set; }  //付费频率

        [Sync((int)AdvertisingUserEnum.DayCostGold)]
        public int DayCostGold { get; set; }  //今日消耗金币数

        [Sync((int)AdvertisingUserEnum.ContinuousLogin)]
        public int ContinuousLogin { get; set; }  //连续登录天数

        [Sync((int)AdvertisingUserEnum.TotalLogin)]
        public int TotalLogin { get; set; }  //登录总天数

        [Sync((int)AdvertisingUserEnum.StageCostGold)]
        public int[] StageCostGold { get; set; }  //关卡消耗金币

        [Sync((int)AdvertisingUserEnum.RuleID)]
        public int RuleID { get; set; }  //插屏规则类型

        public AdvertisingUser()
        {
        }

        public AdvertisingUser(int InID, bool InPay, int InTotalPayMin, int InTotalPayMax, int[] InLoginDays, int[] InLoginProportion, int InLastPaid, float InPaidFrequency, int InDayCostGold, int InContinuousLogin, int InTotalLogin, int[] InStageCostGold, int InRuleID)
        {
            ID = InID;
            Pay = InPay;
            TotalPayMin = InTotalPayMin;
            TotalPayMax = InTotalPayMax;
            LoginDays = InLoginDays;
            LoginProportion = InLoginProportion;
            LastPaid = InLastPaid;
            PaidFrequency = InPaidFrequency;
            DayCostGold = InDayCostGold;
            ContinuousLogin = InContinuousLogin;
            TotalLogin = InTotalLogin;
            StageCostGold = InStageCostGold;
            RuleID = InRuleID;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            string LoginDaysLog = string.Empty;
            for (int i = 0; i < LoginDays.Length; ++i)
            {
                LoginDaysLog += LoginDays[i] + ", ";
            }

            string LoginProportionLog = string.Empty;
            for (int i = 0; i < LoginProportion.Length; ++i)
            {
                LoginProportionLog += LoginProportion[i] + ", ";
            }

            string StageCostGoldLog = string.Empty;
            for (int i = 0; i < StageCostGold.Length; ++i)
            {
                StageCostGoldLog += StageCostGold[i] + ", ";
            }

            return "AdvertisingUser : " + "\n    ID = " + ID + "\n    Pay = " + Pay + "\n    TotalPayMin = " + TotalPayMin + "\n    TotalPayMax = " + TotalPayMax + "\n    LoginDays = " + LoginDaysLog + "\n    LoginProportion = " + LoginProportionLog + "\n    LastPaid = " + LastPaid + "\n    PaidFrequency = " + PaidFrequency + "\n    DayCostGold = " + DayCostGold + "\n    ContinuousLogin = " + ContinuousLogin + "\n    TotalLogin = " + TotalLogin + "\n    StageCostGold = " + StageCostGoldLog + "\n    RuleID = " + RuleID;
        }

    }
}
