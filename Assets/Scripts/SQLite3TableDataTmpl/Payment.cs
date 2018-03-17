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
    public enum PaymentEnum
    {
        ID,
        gold,
        discount,
        text,
        item,
        count,
        infinite_life,
        infinite_time,
        Max
    }

    public class Payment : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)PaymentEnum.ID)]
        public int ID { get; private set; }  //序号

        [Sync((int)PaymentEnum.gold)]
        public int gold { get; set; }  //消费金币|实际*disc

        [Sync((int)PaymentEnum.discount)]
        public float discount { get; set; }  //折扣

        [Sync((int)PaymentEnum.text)]
        public int text { get; set; }  //描述文字

        [Sync((int)PaymentEnum.item)]
        public int item { get; set; }  //物品

        [Sync((int)PaymentEnum.count)]
        public int count { get; set; }  //计数

        [Sync((int)PaymentEnum.infinite_life)]
        public int infinite_life { get; set; }  //无限生命

        [Sync((int)PaymentEnum.infinite_time)]
        public int infinite_time { get; set; }  //无限时效

        public Payment()
        {
        }

        public Payment(int InID, int Ingold, float Indiscount, int Intext, int Initem, int Incount, int Ininfinite_life, int Ininfinite_time)
        {
            ID = InID;
            gold = Ingold;
            discount = Indiscount;
            text = Intext;
            item = Initem;
            count = Incount;
            infinite_life = Ininfinite_life;
            infinite_time = Ininfinite_time;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            return "Payment : " + "\n    ID = " + ID + "\n    gold = " + gold + "\n    discount = " + discount + "\n    text = " + text + "\n    item = " + item + "\n    count = " + count + "\n    infinite_life = " + infinite_life + "\n    infinite_time = " + infinite_time;
        }

    }
}
