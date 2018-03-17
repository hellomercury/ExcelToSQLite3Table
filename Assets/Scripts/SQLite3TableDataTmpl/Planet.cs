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
    public enum PlanetEnum
    {
        ID,
        Name,
        resId,
        MapResource,
        Max
    }

    public class Planet : SyncBase
    {
        [SQLite3Constraint(SQLite3Constraint.Unique | SQLite3Constraint.NotNull )]
        [Sync((int)PlanetEnum.ID)]
        public int ID { get; private set; }

        [Sync((int)PlanetEnum.Name)]
        public string Name { get; set; }

        [Sync((int)PlanetEnum.resId)]
        public int resId { get; set; }

        [Sync((int)PlanetEnum.MapResource)]
        public int[] MapResource { get; set; }

        public Planet()
        {
        }

        public Planet(int InID, string InName, int InresId, int[] InMapResource)
        {
            ID = InID;
            Name = InName;
            resId = InresId;
            MapResource = InMapResource;
        }

        //-------------------------------*Self Code Begin*-------------------------------
        //Custom code.
        //-------------------------------*Self Code End*   -------------------------------
        

        public override string ToString()
        {
            string MapResourceLog = string.Empty;
            for (int i = 0; i < MapResource.Length; ++i)
            {
                MapResourceLog += MapResource[i] + ", ";
            }

            return "Planet : " + "\n    ID = " + ID + "\n    Name = " + Name + "\n    resId = " + resId + "\n    MapResource = " + MapResourceLog;
        }

    }
}
