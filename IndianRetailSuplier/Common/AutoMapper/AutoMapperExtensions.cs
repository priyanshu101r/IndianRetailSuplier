using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianRetailSuplier.Common.AutoMapper
{
    public static class AutoMapperExtensions
    {
        public static List<TResult> MapTo<TResult>(this IEnumerable self, object additionalArguments)
        {
            if (self == null)
                return default(List<TResult>); //throw new ArgumentNullException();

            return (List<TResult>)IndianRetailSuplierAutoMapper.Mapper.Map(self, self.GetType(), typeof(List<TResult>),
                (opts => { opts.Items.Add("additional_arguments", additionalArguments); }));
        }
        public static TResult MapToSingleObject<TResult>(this IEnumerable self, object additionalArguments)
        {
            if (self == null)
                return default(TResult); //throw new ArgumentNullException();

            return (TResult)IndianRetailSuplierAutoMapper.Mapper.Map(self, self.GetType(), typeof(TResult),
                (opts => { opts.Items.Add("additional_arguments", additionalArguments); }));
        }


        public static List<TResult> MapTo<TResult>(this IEnumerable self)
        {
            if (self == null)
                return default(List<TResult>); //throw new ArgumentNullException();

            return (List<TResult>)IndianRetailSuplierAutoMapper.Mapper.Map(self, self.GetType(), typeof(List<TResult>));
        }

        public static TResult MapToSingleObject<TResult>(this IEnumerable self)
        {
            if (self == null)
                return default(TResult); //throw new ArgumentNullException();

            return (TResult)IndianRetailSuplierAutoMapper.Mapper.Map(self, self.GetType(), typeof(TResult));
        }

        public static List<TResult> MapSingleObjectToList<TResult>(this object self)
        {
            if (self == null)
                return default(List<TResult>); //throw new ArgumentNullException();

            return (List<TResult>)IndianRetailSuplierAutoMapper.Mapper.Map(self, self.GetType(), typeof(List<TResult>));
        }

        public static TResult MapTo<TResult>(this object self)
        {
            if (self == null)
                return default(TResult); //throw new ArgumentNullException();

            return (TResult)IndianRetailSuplierAutoMapper.Mapper.Map(self, self.GetType(), typeof(TResult));
        }

        public static TResult MapPropertiesToInstance<TResult>(this object self, TResult value)
        {
            if (self == null)
                return default(TResult); //throw new ArgumentNullException();

            return (TResult)IndianRetailSuplierAutoMapper.Mapper.Map(self, value, self.GetType(), typeof(TResult));
        }

        public static TResult MapTo<TResult>(this object self, object additionalArguments)
        {
            if (self == null)
                return default(TResult); //throw new ArgumentNullException();

            return (TResult)IndianRetailSuplierAutoMapper.Mapper.Map(self, self.GetType(), typeof(TResult),
                (opts => { opts.Items.Add("additional_arguments", additionalArguments); }));
        }
    }
}
