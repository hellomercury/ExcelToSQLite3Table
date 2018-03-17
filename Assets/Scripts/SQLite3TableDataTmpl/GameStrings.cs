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
    public enum GameStringsEnum
    {
        ID,
        Content,
        Max
    }

    public class GameStrings : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)GameStringsEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)GameStringsEnum.Content)]
        public string Content { get; set; }

        public GameStrings()
        {
        }

        public GameStrings(int InID, string InContent)
        {
            ID = InID;
            Content = InContent;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "GameStrings : " + "\n    ID = " + ID + "\n    Content = " + Content;
        }

    }
}
