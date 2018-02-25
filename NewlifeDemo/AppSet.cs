using NewLife.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewlifeDemo
{
    /// <summary>应用自定义配置</summary>
    [Description("应用自定义配置")]
    [XmlConfigFile("Config/AppSet.config", 3000)]
    public class AppSet : XmlConfig<AppSet>
    {
        /// <summary>调试开关。默认false</summary>
        [Description("调试开关。默认false")]
        public Boolean Debug { get; set; } = false;
        /// <summary>每批次处理的数据记录数</summary>
        [Description("每批次处理的数据记录数")]
        public Int32 BatchSize { get; set; } = 20000;
        
        /// <summary>服务名称</summary>
        [Description("服务名称")]
        public String ServiceName { get; set; } = "AppServer";

        /// <summary>缓存清理时间</summary>
        [Description("缓存清理时间")]
        public DateTime CacheTime { get; set; } = DateTime.Now.AddHours(5);

        /// <summary>要监控的用户ID列表</summary>
        [Description("要监控的用户ID列表")]
        public List<Int32> UserList { get; set; } = new List<int>() { 123,23,98,38};

        /// <summary>键值对</summary>
        [Description("键值对")]
        public Dictionary<Int32, string> KvDemo { get; set; } = 
            new Dictionary<int, string>(){ { 1,"aaa"},{2,"bbb"},{ 3,"ccc"} };

        public Student DefaultStudent { get; set; } = 
            new Student() { Name = "小明",Age = 23,Birth = DateTime.Now.AddYears(-23)};
    }

    public class  Student
    {
        public string Name { get; set; }
        public Int32 Age { get; set; }
        public DateTime Birth { get; set; }
    }
}