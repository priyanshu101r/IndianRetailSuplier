using AutoMapper;
using IndianRetailSuplier.Common.AutoMapper.AutoMapperProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianRetailSuplier.Common.AutoMapper
{
    public class IRS_WebAutoMapperConfiguration
    {
        public static MapperConfigurationExpression MappingExpressions = new MapperConfigurationExpression();

        private static object lockObj = new object();
        private static bool alreadyConfigured = false;

        public static void Configure(MapperConfigurationExpression cfg)
        {
            if (alreadyConfigured)
                return;

            lock (lockObj)
            {
                if (alreadyConfigured)
                    return;

                alreadyConfigured = true;

                cfg.AddProfile(new UserProfile());
                //cfg.AddProfile(new SitemapAreaProfile());
                //cfg.AddProfile(new SitemapGroupProfile());
                //cfg.AddProfile(new SitemapNodeProfile());
                //cfg.AddProfile(new ErpPageProfile());
                //cfg.AddProfile(new PageBodyNodeProfile());
                //cfg.AddProfile(new ValidationErrorProfile());
                //cfg.AddProfile(new PageDataSourceProfile());


            }
        }
    }
}
