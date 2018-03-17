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
    public enum FriendEnum
    {
        ID,
        FriendNum,
        Max
    }

    public class Friend : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)FriendEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)FriendEnum.FriendNum)]
        public int FriendNum { get; set; }

        public Friend()
        {
        }

        public Friend(int InID, int InFriendNum)
        {
            ID = InID;
            FriendNum = InFriendNum;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "Friend : " + "\n    ID = " + ID + "\n    FriendNum = " + FriendNum;
        }

    }
}
