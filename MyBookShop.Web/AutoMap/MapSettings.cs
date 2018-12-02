using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBookShop.Models;
using MyBookShop.Web.ViewModel;

namespace MyBookShop.Web.AutoMap
{
    public class MapSettings
    {
        /// <summary>
        /// 注册所有的对象映射规则;    
        /// </summary>
        public static void MapConfigSettings()
        {
            Mapper.Initialize(s => s.CreateMap<ConactViewModel, CustomerMessage>()
            .ForMember(d => d.Title, x => x.MapFrom(y => y.Subject))
            .ForMember(d => d.Msg, x => x.MapFrom(y => y.Message)));
        }


    }
}
