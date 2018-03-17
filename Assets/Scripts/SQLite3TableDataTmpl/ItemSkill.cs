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
    public enum ItemSkillEnum
    {
        ID,
        Name,
        Num,
        Max
    }

    public class ItemSkill : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)ItemSkillEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)ItemSkillEnum.Name)]
        public string Name { get; set; }

        [Sync((int)ItemSkillEnum.Num)]
        public int Num { get; set; }

        public ItemSkill()
        {
        }

        public ItemSkill(int InID, string InName, int InNum)
        {
            ID = InID;
            Name = InName;
            Num = InNum;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "ItemSkill : " + "\n    ID = " + ID + "\n    Name = " + Name + "\n    Num = " + Num;
        }

    }
}
