using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cards.Extension
{
    public static class EnumExtension
    {
        public static TEnum IntToEnum<TEnum>(this int intEnum) where TEnum: struct, Enum
        {
            var royalCard = (TEnum)Enum.ToObject(typeof(TEnum), intEnum);

            return royalCard;
        }
    }
}
