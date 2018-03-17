using System;
using System.Text;
using Framework.Config;
using Framework.SQLite3Helper;
using UnityEngine;
using UnityEngine.Assertions;

namespace Framework.Tools
{
    public static class Utility
    {
        public static string ConvertValueType(object InValue, Type InType = null)
        {
            if (null == InType) InType = InValue.GetType();
            if (InType.IsValueType)
            {
                if (InType == ConstData.BOOL_TYPE) return Boolean.Parse(InValue.ToString()) ? "1" : "0";
                else return InValue.ToString();
            }
            else if (InType.IsArray)
            {
                Type eleType = InType.GetElementType();
                while (eleType.IsArray) eleType = eleType.GetElementType();
                return eleType.IsClass ? CheckStringSingleQuoteMatch(ConvertArrayToString(InValue))
                    : ConvertArrayToString(InValue);
            }
            else if (InType.IsClass) return CheckStringSingleQuoteMatch(InValue.ToString());
            else return InValue.ToString();
        }

        public static string CheckStringSingleQuoteMatch(string InStr)
        {
            char[] charArray = InStr.ToCharArray();
            int charLen = charArray.Length;
            int start = charArray[0] == '\'' ? 1 : 0;
            int end = charArray[charLen - 1] == '\'' ? charLen - 1 : charLen;
            StringBuilder charSB = new StringBuilder(charLen * 2);
            charSB.Append('\'');
            for (int i = start; i < end; ++i)
            {
                charSB.Append(charArray[i]);
                if (charArray[i] == '\'') charSB.Append('\'');
            }
            charSB.Append('\'');

            return charSB.ToString();
        }

        public static string ConvertArrayToString(object InArray)
        {
            Type type = InArray.GetType();
            Assert.IsTrue(type.IsArray);
            Type firstEleType = type.GetElementType();
            if (firstEleType.IsArray)
            {
                Type secType = firstEleType.GetElementType();
                if (secType.IsArray)
                {
                    Type thirdType = secType.GetElementType();
                    if (thirdType.IsArray)
                    {
                        Debug.LogError("NOT SUPPORT!");
                        return string.Empty;
                    }
                    else
                    {
                        Array array = InArray as Array, secArray, thirdArray;
                        int length = array.Length, secArrayLen, thirdArrayLen;
                        StringBuilder sb = new StringBuilder(length * 64);
                        for (int i = 0; i < length; ++i)
                        {
                            secArray = array.GetValue(i) as Array;
                            secArrayLen = secArray.Length;
                            for (int j = 0; j < secArrayLen; ++j)
                            {
                                thirdArray = secArray.GetValue(j) as Array;
                                thirdArrayLen = thirdArray.Length;
                                for (int k = 0; k < thirdArrayLen; ++k)
                                {
                                    sb.Append(thirdArray.GetValue(k)).Append(SQLite3Config.FIRST_ARRAY_SPLIT_C);
                                }
                                sb.Remove(sb.Length - 1, 1);
                                sb.Append(SQLite3Config.SECOND_ARRAY_SPLIT_C);
                            }
                            sb.Remove(sb.Length - 1, 1);
                            sb.Append(SQLite3Config.THIRD_ARRAY_SPLIT_C);
                        }

                        sb.Remove(sb.Length - 1, 1);
                        return sb.ToString();
                    }
                }
                else
                {
                    Array array = InArray as Array, secArray;
                    int length = array.Length, secArrayLen;
                    StringBuilder sb = new StringBuilder(length * 32);
                    for (int i = 0; i < length; ++i)
                    {
                        secArray = array.GetValue(i) as Array;
                        secArrayLen = secArray.Length;
                        for (int j = 0; j < secArrayLen; ++j)
                        {
                            sb.Append(secArray.GetValue(j)).Append(SQLite3Config.FIRST_ARRAY_SPLIT_C);
                        }
                        sb.Remove(sb.Length - 1, 1);
                        sb.Append(SQLite3Config.SECOND_ARRAY_SPLIT_C);
                    }
                    sb.Remove(sb.Length - 1, 1);
                    return sb.ToString();
                }
            }
            else
            {
                Array array = InArray as Array;
                int length = array.Length;
                StringBuilder sb = new StringBuilder(length * 16);
                for (int i = 0; i < length; ++i)
                {
                    sb.Append(array.GetValue(i)).Append(SQLite3Config.FIRST_ARRAY_SPLIT_C);
                }

                sb.Remove(sb.Length - 1, 1);
                return sb.ToString();
            }
        }

        public static string ConvertArrayToString<T>(T[] InArray)
        {
            int length = InArray.Length;
            StringBuilder sb = new StringBuilder(length * 16);
            for (int i = 0; i < length; ++i)
            {
                sb.Append(InArray[i]).Append(SQLite3Config.FIRST_ARRAY_SPLIT_C);
            }

            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        public static string ConvertArrayToString<T>(T[][] InArray)
        {
            int length = InArray.Length, secArrayLen;
            StringBuilder sb = new StringBuilder(length * 32);
            for (int i = 0; i < length; ++i)
            {
                secArrayLen = InArray[i].Length;
                for (int j = 0; j < secArrayLen; ++j)
                {
                    sb.Append(InArray[i][j]).Append(SQLite3Config.FIRST_ARRAY_SPLIT_C);
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append(SQLite3Config.SECOND_ARRAY_SPLIT_C);
            }
            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }

        public static string ConvertArrayToString<T>(T[][][] InArray)
        {
            int length = InArray.Length, secArrayLen, thirdArrayLen;
            StringBuilder sb = new StringBuilder(length * 64);
            for (int i = 0; i < length; ++i)
            {
                secArrayLen = InArray[i].Length;
                for (int j = 0; j < secArrayLen; ++j)
                {
                    thirdArrayLen = InArray[i][j].Length;
                    for (int k = 0; k < thirdArrayLen; ++k)
                    {
                        sb.Append(InArray[i][j][k]).Append(SQLite3Config.FIRST_ARRAY_SPLIT_C);
                    }
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append(SQLite3Config.SECOND_ARRAY_SPLIT_C);
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append(SQLite3Config.THIRD_ARRAY_SPLIT_C);
            }

            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        public static object ConvertStringToArray(string InArrayStr, Type InType)
        {
            if (string.IsNullOrEmpty(InArrayStr) || !InType.IsArray) return null;
            else
            {
                Array array = null;
                Type firstEleType = InType.GetElementType();
                int rank = InType.GetArrayRank();
                switch (rank)
                {
                    case 1:
                        if (firstEleType.IsArray)
                        {
                            Type secEleType = firstEleType.GetElementType();
                            if (secEleType.IsArray)
                            {
                                Type thirdEleType = secEleType.GetElementType();
                                if (thirdEleType.IsArray) Debug.LogError("Not support.");
                                else
                                {
                                    string[] firstArrayStr = InArrayStr.Split(SQLite3Config.THIRD_ARRAY_SPLIT_C);
                                    int firstArrayLen = firstArrayStr.Length;

                                    array = Array.CreateInstance(firstEleType, firstArrayLen);
                                    for (int i = 0; i < firstArrayLen; ++i)
                                    {
                                        string[] secArrayStr = firstArrayStr[i].Split(SQLite3Config.SECOND_ARRAY_SPLIT_C);
                                        int secArrayLen = secArrayStr.Length;

                                        Array secArray = Array.CreateInstance(secEleType, secArrayLen);

                                        for (int j = 0; j < secArrayLen; ++j)
                                        {
                                            string[] thirdArrayStr = secArrayStr[j].Split(SQLite3Config.FIRST_ARRAY_SPLIT_C);
                                            int thirdArrayLen = thirdArrayStr.Length;

                                            Array thirdArray = Array.CreateInstance(thirdEleType, thirdArrayLen);

                                            for (int k = 0; k < thirdArrayLen; ++k)
                                            {
                                                thirdArray.SetValue(Convert.ChangeType(thirdArrayStr[k], thirdEleType), k);
                                            }
                                            secArray.SetValue(thirdArray, j);
                                        }
                                        array.SetValue(secArray, i);
                                    }
                                }
                            }
                            else
                            {
                                string[] firstArrayStr = InArrayStr.Split(SQLite3Config.SECOND_ARRAY_SPLIT_C);
                                int firstArrayLen = firstArrayStr.Length;

                                array = Array.CreateInstance(firstEleType, firstArrayLen);
                                string[] secArrayStr;
                                for (int i = 0; i < firstArrayLen; ++i)
                                {
                                    secArrayStr = firstArrayStr[i].Split(SQLite3Config.FIRST_ARRAY_SPLIT_C);
                                    int secArrayLen = secArrayStr.Length;
                                    Array secArray = Array.CreateInstance(secEleType, secArrayLen);
                                    for (int j = 0; j < secArrayLen; ++j)
                                    {
                                        secArray.SetValue(Convert.ChangeType(secArrayStr[j], secEleType), j);
                                    }
                                    array.SetValue(secArray, i);
                                }
                            }
                        }
                        else
                        {
                            string[] firstArrayStr = InArrayStr.Split(SQLite3Config.FIRST_ARRAY_SPLIT_C);
                            int firstArrayLen = firstArrayStr.Length;

                            array = Array.CreateInstance(firstEleType, firstArrayLen);
                            for (int i = 0; i < firstArrayLen; ++i)
                            {
                                array.SetValue(Convert.ChangeType(firstArrayStr[i], firstEleType), i);
                            }
                        }

                        break;

                    default:
                        return null;
                }

                return array;
            }
        }
    }
}