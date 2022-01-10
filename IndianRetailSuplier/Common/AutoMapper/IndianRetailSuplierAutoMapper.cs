using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianRetailSuplier.Common.AutoMapper
{
    public static class IndianRetailSuplierAutoMapper
    {
        public static IMapper Mapper = null;

        public static void Initialize(MapperConfigurationExpression cfg)
        {
            Mapper = new Mapper(new MapperConfiguration(cfg));
        }
    }
}
