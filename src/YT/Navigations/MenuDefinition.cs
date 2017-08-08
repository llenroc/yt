using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter;

namespace YT.Navigations
{
    public class MenuDefinition
    {
        public MenuDefinition() { }

        public MenuDefinition(string name, string title, string url)
        {
            Name = name;
            DisplayName = title;
            Url = url; 
            Childs=new List<MenuDefinition>();
        }
        public MenuDefinition(string name, string title, string url,List<MenuDefinition> childs )
        {
            Name = name;
            DisplayName = title;
            Url = url;
            Childs = childs;
        }
        /// <summary>
        /// 菜单名称(唯一)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 菜单显示名称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 元数据
        /// </summary>
        public string MetaData { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// 链接
        /// </summary>
        public string Url { get; set; }


        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 是否系统
        /// </summary>
        public bool IsStatic { get; set; }
        /// <summary>
        /// 下级菜单
        /// </summary>
        public List<MenuDefinition> Childs { get; set; }
        /// <summary>
        /// 是否激活
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// 上级菜单
        /// </summary>
        public int? ParentId { get; set; }

    }
}
