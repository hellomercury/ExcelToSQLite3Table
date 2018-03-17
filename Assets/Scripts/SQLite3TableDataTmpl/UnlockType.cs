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
    public enum UnlockTypeEnum
    {
        ID,
        type,
        Max
    }

    public class UnlockType : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)UnlockTypeEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)UnlockTypeEnum.type)]
        public string type { get; set; }

        public UnlockType()
        {
        }

        public UnlockType(int InID, string Intype)
        {
            ID = InID;
            type = Intype;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "UnlockType : " + "\n    ID = " + ID + "\n    type = " + type;
        }

    }
}
