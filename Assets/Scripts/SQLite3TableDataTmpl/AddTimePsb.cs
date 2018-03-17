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
    public enum AddTimePsbEnum
    {
        ID,
        AddTime,
        Possibility,
        Max
    }

    public class AddTimePsb : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)AddTimePsbEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)AddTimePsbEnum.AddTime)]
        public int AddTime { get; set; }  //时间

        [Sync((int)AddTimePsbEnum.Possibility)]
        public int Possibility { get; set; }  //概率

        public AddTimePsb()
        {
        }

        public AddTimePsb(int InID, int InAddTime, int InPossibility)
        {
            ID = InID;
            AddTime = InAddTime;
            Possibility = InPossibility;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "AddTimePsb : " + "\n    ID = " + ID + "\n    AddTime = " + AddTime + "\n    Possibility = " + Possibility;
        }

    }
}
