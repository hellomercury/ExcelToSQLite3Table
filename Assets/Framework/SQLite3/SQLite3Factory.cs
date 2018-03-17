using System;
using System.IO;
using UnityEngine;

namespace Framework.SQLite3Helper
{
    public static class SQLite3Factory
    {
        public static SQLite3Operate OpenToReadOnly(string InDbName)
        {
            string persistentDbPath = Path.Combine(Application.persistentDataPath, InDbName);

            if (File.Exists(persistentDbPath)) return new SQLite3Operate(persistentDbPath, SQLite3OpenFlags.ReadOnly);
            else return null;
        }

        public static SQLite3Operate OpenToReadOnly(string InDbName, bool InIsNeedCheck, string InMd5 = null)
        {
            string persistentDbPath = Path.Combine(Application.persistentDataPath, InDbName);

#if !UNITY_EDITOR && UNITY_ANDROID
            string streamDbPath = Path.Combine("jar:file://" + Application.dataPath + "!/assets/", InDbName);
#elif UNITY_IOS
            string streamDbPath = Path.Combine(Application.dataPath + "/Raw/", InDbName);
#else
            string streamDbPath = Path.Combine(Application.streamingAssetsPath, InDbName);
#endif

            bool isNeedOverride = false;
            byte[] dbBytes = null;
            if (File.Exists(persistentDbPath))
            {
                if (InIsNeedCheck)
                {
                    if (string.IsNullOrEmpty(InMd5))
                    {
#if !UNITY_EDITOR && UNITY_ANDROID
                        using (WWW www = new WWW(streamDbPath))
                        {
                            while (!www.isDone)
                            {
                            }

                            if (string.IsNullOrEmpty(www.error))
                            {
                                dbBytes = www.bytes;
                                isNeedOverride = !GetFileMD5ByByte(dbBytes).Equals(GetFileMD5(persistentDbPath));
                            }
                            else isNeedOverride = true;
                        }
#else
                        dbBytes = File.ReadAllBytes(streamDbPath);
                        isNeedOverride = !SQLite3Utility.GetBytesMD5(dbBytes).Equals(SQLite3Utility.GetFileMD5(persistentDbPath));
#endif
                    }
                    else isNeedOverride = !InMd5.Equals(persistentDbPath);
                }
            }
            else isNeedOverride = true;

            if (isNeedOverride)
            {
                if (null == dbBytes)
                {
#if !UNITY_EDITOR && UNITY_ANDROID
                    using (WWW www = new WWW(streamDbPath))
                    {
                        while (!www.isDone)
                        {
                        }

                        if (string.IsNullOrEmpty(www.error)) dbBytes = www.bytes;
                        else Debug.LogError("Copy database from streamingAssetsPath to persistentDataPath error. " + www.error);
                    }
#else
                    dbBytes = File.ReadAllBytes(streamDbPath);
#endif
                }

                File.WriteAllBytes(persistentDbPath, dbBytes);
            }

            return new SQLite3Operate(persistentDbPath, SQLite3OpenFlags.ReadOnly);
        }

        public static SQLite3Operate OpenToReadWrite(string InDbName)
        {
            string persistentDbPath = Path.Combine(Application.persistentDataPath, InDbName);

            if (File.Exists(persistentDbPath)) return new SQLite3Operate(persistentDbPath, SQLite3OpenFlags.Create | SQLite3OpenFlags.ReadWrite);
            else return null;
        }

        public static SQLite3Operate OpenToReadWrite(string InDbName, bool InIsNeedCheck, string InMd5 = null, Func<string, SQLite3Operate> InCheckFailAction = null)
        {
            string persistentDbPath = Path.Combine(Application.persistentDataPath, InDbName);

            if (File.Exists(persistentDbPath))
            {
                if (InIsNeedCheck && !string.IsNullOrEmpty(InMd5) && null != InCheckFailAction)
                {
                    if (!SQLite3Utility.GetFileMD5(persistentDbPath).Equals(InMd5)) return InCheckFailAction.Invoke(InDbName);
                }

                return new SQLite3Operate(persistentDbPath, SQLite3OpenFlags.ReadWrite);//
            }
            else if (null != InCheckFailAction) return InCheckFailAction.Invoke(InDbName);
            else return null;
        }

        public static SQLite3Operate OpenOrCreate(string InDbName)
        {
            return new SQLite3Operate(Path.Combine(Application.persistentDataPath, InDbName), SQLite3OpenFlags.Create | SQLite3OpenFlags.ReadWrite);
        }
    }
}