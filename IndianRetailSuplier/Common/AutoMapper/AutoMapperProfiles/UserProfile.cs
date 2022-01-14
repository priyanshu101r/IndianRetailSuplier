using AutoMapper;
using IndianRetailSuplier.DATA.Models;
using IndianRetailSuplier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianRetailSuplier.Common.AutoMapper.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Category, CategoryViewModel>().ConvertUsing(source => JTokenToErpPageConvert(source));
            //  CreateMap<ErpPage, EntityRecord>().ConvertUsing(source => ErpPageToEntityRecordConvert(source));
        }

        private static CategoryViewModel JTokenToErpPageConvert(Category data)
        {
            if (data == null)
                return null;

            CategoryViewModel model = new CategoryViewModel();
            model.id = data.Id;
            model.CategoryName = data.CategoryName;
            model.Description = data.Description;
            return model;
        }
    }
}
