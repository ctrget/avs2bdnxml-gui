using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Net;
using System.Windows.Forms;

namespace avs2bdnxml_gui
{
    public class HashConfig
    {
        private static Hashtable _hc = new Hashtable();
        public static string FileName { get; set; }




        /// <summary>
        /// 构造一个HashConfig对象实例
        /// </summary>
        /// <param name="fname">需要操作的配置文件完整路径</param>
        /// <returns></returns>
        public HashConfig(string fname = null)
        {
            FileName = fname;
        }

        /// <summary>
        /// 从文件载入HashConfig配置
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public void LoadFromFile()
        {
            if (FileName == null)
                return;

            FileStream fs;
            fs = new FileStream(FileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            _hc = (Hashtable)bf.Deserialize(fs);
            fs.Close();
        }

        /// 将HashConfig保存至配置文件
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        public void SaveFromFile()
        {
            if (FileName == null)
                return;

            FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, _hc);
            fs.Close();

        }

        /// <summary>
        /// 读取HashConfig指定项下的键
        /// </summary>
        /// <param name="section">需要读取的项</param>
        /// <param name="key">需要读取的键</param>
        /// <returns>返回读取结果 无此项或者键返回null</returns>
        public object ReadKeyO(string section, string key)
        {
            if (_hc.Contains(section + "^" + key) == false)
                return null;
            return _hc[section + "^" + key];
        }

        /// <summary>
        /// 读取HashConfig指定项下的键
        /// </summary>
        /// <param name="section">需要读取的项</param>
        /// <param name="key">需要读取的键</param>
        /// <returns>返回读取结果 无此项或者键返回null</returns>
        public string ReadKey(string section, string key)
        {
            if (_hc.Contains(section + "^" + key) == false)
                return null;
            string s = (string)_hc[section + "^" + key];
            return s;
        }

        /// <summary>
        /// 枚举HashConfig指定项下的所有键
        /// </summary>
        /// <param name="section">需要枚举的项</param>
        /// <returns>返回该项下所有的键 如无此项返回null</returns>
        public List<string> EnumKey(string section)
        {
            List<string> ls = new List<string>();
            foreach (DictionaryEntry de in _hc)
            {
                string s = de.Key.ToString();
                string index = s.Split('^')[0];
                string node = s.Split('^')[1];

                if (index == section)
                    ls.Add(node);
            }

            if (ls.Count > 0)
                return ls;

            return null;

        }

        /// <summary>
        /// 写入HashConfig指定项下的键
        /// </summary>
        /// <param name="section">需要写入的项</param>
        /// <param name="key">需要写入的键</param>
        /// <param name="value">需要写入的值</param>
        /// <returns></returns>
        public void WriteKey(string section, string key, object value)
        {
            if (_hc.Contains(section + "^" + key) == true)
                _hc.Remove(section + "^" + key);
            _hc.Add(section + "^" + key, value);
            return;
        }

        /// <summary>
        /// 移除HashConfig指定项下的键
        /// </summary>
        /// <param name="section">需要操作的项</param>
        /// <param name="key">需要删除的键</param>
        /// <returns></returns>
        public void RemoveKey(string section, string key)
        {
            if (_hc.Contains(section + "^" + key) == true)
                _hc.Remove(section + "^" + key);

            return;
        }


        /// <summary>
        /// 移除指定项下的所有键
        /// </summary>
        /// <param name="section">需要操作的项</param>
        /// <returns></returns>
        public void RemoveSection(string section)
        {
            List<string> ls = this.EnumKey(section);

            if (ls == null)
                return;

            foreach (string s in ls)
            {
                this.RemoveKey(section, s);
            }

        }
    }
}
