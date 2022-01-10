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
            CreateMap<User, UserViewModel>().ConvertUsing(source => JTokenToErpPageConvert(source));
            //  CreateMap<ErpPage, EntityRecord>().ConvertUsing(source => ErpPageToEntityRecordConvert(source));
        }

        private static UserViewModel JTokenToErpPageConvert(User data)
        {
            if (data == null)
                return null;

            UserViewModel model = new UserViewModel();
            model.Id = Convert.ToString(data.Id);
            model.firstName = data.firstName;
            model.lastName = data.lastName;
            model.email = data.email;
            model.mobilenumber = Convert.ToString(data.mobilenumber);
            //BODY IS NOT INIT HERE - IT SHOULD BE LOADED LAZY

            return model;
        }
    }
}
