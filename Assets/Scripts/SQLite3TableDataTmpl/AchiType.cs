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
    public enum AchiTypeEnum
    {
        ID,
        Type,
        Max
    }

    public class AchiType : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)AchiTypeEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)AchiTypeEnum.Type)]
        public string Type { get; set; }  //成就类别

        public AchiType()
        {
        }

        public AchiType(int InID, string InType)
        {
            ID = InID;
            Type = InType;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "AchiType : " + "\n    ID = " + ID + "\n    Type = " + Type;
        }

    }
}
