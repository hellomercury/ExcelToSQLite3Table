using System;
using System.Collections.Generic;
using System.Reflection;
using Framework.Tools;
using LitJson;
using UnityEngine;

namespace Framework.Sync
{
    public class SyncProperty
    {
        public Type ClassType { get; private set; }
        public string ClassName { get; private set; }
        public PropertyInfo[] Infos { get; }
        public int InfosLength { get; private set; }
        public Dictionary<string, PropertyInfo> InfoDicts { get; }

        public SyncProperty(Type InClassType, string InClassName, PropertyInfo[] InInfos, Dictionary<string, PropertyInfo> InInfoDict, int InInfosLength)
        {
            ClassType = InClassType;
            ClassName = InClassName;
            Infos = InInfos;
            InfosLength = InInfosLength;
            InfoDicts = InInfoDict;
        }
    }

    public class SyncFactory
    {
        private Type classType;
        private PropertyInfo[] propertyInfos;
        private Dictionary<string, PropertyInfo> infoDict;
        private int propertyInfoLength;
        private SyncProperty Property;

        public SyncFactory(Type InType)
        {
            classType = InType;
            PropertyInfo[] infos = InType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            propertyInfoLength = infos.Length;
            propertyInfos = new PropertyInfo[propertyInfoLength];
            infoDict = new Dictionary<string, PropertyInfo>(propertyInfoLength);
            int syncID;
            Type syncAttrType = typeof(SyncAttribute);
            for (int i = 0; i < propertyInfoLength; i++)
            {
                object[] attrs = infos[i].GetCustomAttributes(syncAttrType, false);
                if (1 == attrs.Length && attrs[0] is SyncAttribute)
                {
                    syncID = (attrs[0] as SyncAttribute).SyncID;
                    if (-1 < syncID && syncID < propertyInfoLength)
                    {
                        propertyInfos[syncID] = infos[i];
                        infoDict.Add(infos[i].Name, infos[i]);
                    }
                    else throw new IndexOutOfRangeException("Please set SyncAttribute to the property according to the sequence.");
                }
            }

            Property = new SyncProperty(classType, classType.Name, propertyInfos, infoDict, propertyInfoLength);
        }

        public void OnSyncOne(object InObj, int InInfoIndex, object InValue)
        {
            if (null == InObj) throw new ArgumentNullException();
            if (0 > InInfoIndex || InInfoIndex >= propertyInfoLength) throw new IndexOutOfRangeException(InInfoIndex + "< 0 || " + InInfoIndex + " >= " + propertyInfoLength);
            if (InObj.GetType() != classType) throw new ArgumentException("The input type not matched.");

            OnSyncOne(InObj, propertyInfos[InInfoIndex], InValue);
        }

        public void OnSyncOne(object InObj, string InInfoName, object InValue)
        {
            if (null == InObj) throw new ArgumentNullException();
            if (string.IsNullOrEmpty(InInfoName) || infoDict.ContainsKey(InInfoName)) throw new Exception("UnKnow property name.");
            if (InObj.GetType() != classType) throw new ArgumentException("The input type not matched.");

        }


        public void OnSyncOne(object InObj, PropertyInfo InInfo, object InValue)
        {
            if (null != InObj && null != InInfo && null != InValue)
            {
                object oldValue = InInfo.GetValue(InObj, null);
                if (!InValue.Equals(oldValue))
                {
                    if (null == oldValue || InValue.GetType() != InInfo.PropertyType) InValue = Utility.ConvertValueType(InValue, InInfo.PropertyType);
                    Debug.LogError(InValue);
                    InInfo.SetValue(InObj, InValue, null);
                    if (InObj is SyncBase) (InObj as SyncBase).OnPropertyChanged(InInfo.Name, oldValue, InValue);
                }
            }
        }

        public void OnSyncAll(object InObj, JsonData InJsonData)
        {
            if (InJsonData.Count != propertyInfoLength)
                Debug.LogError(classType.Name + " 协议数量不匹配。\n属性个数 ： " + infoDict.Count + " != 协议个数：" + InJsonData.Count);
            foreach (KeyValuePair<string, PropertyInfo> itor in infoDict)
            {
                JsonData jsonData = InJsonData[itor.Key];
                itor.Value.SetValue(InObj, Utility.ConvertValueType(jsonData == null ? string.Empty : jsonData.ToString(), itor.Value.PropertyType), null);
            }
        }

        private static Dictionary<Type, SyncFactory> factoriesDict = new Dictionary<Type, SyncFactory>();
        public static SyncFactory GetOrCreateSyncFactory(Type InType)
        {
            SyncFactory factory;
            if (!factoriesDict.TryGetValue(InType, out factory))
            {
                try
                {
                    factory = new SyncFactory(InType);
                    factoriesDict.Add(InType, factory);
                }
                catch (Exception ex)
                {
                    Debug.LogError(InType + " Create SyncFactory Error : " + ex.Message);
                }
            }

            return factory;
        }

        public static SyncProperty GetSyncProperty<T>() where T : SyncBase
        {
            return GetOrCreateSyncFactory(typeof(T)).Property;
        }

        public static SyncProperty GetSyncProperty(object InObj)
        {
            return GetOrCreateSyncFactory(InObj.GetType()).Property;
        }

        public static SyncProperty GetSyncProperty(Type InType)
        {
            return GetOrCreateSyncFactory(InType).Property;
        }
    }
}