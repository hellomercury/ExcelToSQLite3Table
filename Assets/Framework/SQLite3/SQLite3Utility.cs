using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

namespace Framework.SQLite3Helper
{
    public class SQLite3Utility
    {
        private static MD5 md5;
        public static string GetFileMD5(string InFilePath)
        {
            try
            {
                return File.Exists(InFilePath) ? GetBytesMD5(File.ReadAllBytes(InFilePath)) : "";
            }
            catch (FileNotFoundException e)
            {
                Debug.LogError(e.Message);
                return "";
            }
        }

        public static string GetBytesMD5(byte[] InBytes)
        {
            if (null == md5) md5 = new MD5CryptoServiceProvider();

            byte[] result = md5.ComputeHash(InBytes);
            StringBuilder sb = new StringBuilder(32);
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("x2"));
            }

            return sb.ToString();
        }

        public static string ConvertSQLite3ConstraintToStr(SQLite3Constraint InConstraint)
        {
            string result = string.Empty;
            if ((InConstraint & SQLite3Constraint.PrimaryKey) != 0)
                result += " PrimaryKey ";
            if ((InConstraint & SQLite3Constraint.Unique) != 0)
                result += " Unique ";
            if ((InConstraint & SQLite3Constraint.AutoIncrement) != 0)
                result += " AutoIncrement ";
            if ((InConstraint & SQLite3Constraint.NotNull) != 0)
                result += " NotNull ";

            return result == string.Empty ? string.Empty : result.Remove(result.Length - 1, 1);
        }
    }
}