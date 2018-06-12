using Conditions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Conditions
{
    public static class ConditionValidatorExtension
    {
        /// <summary>
        /// 校验字符串是否由中英文或数字或横线和下划线构成
        /// </summary>
        public static ConditionValidator<T> IsWordOrNumberOrLine<T>(this ConditionValidator<T> validator)
        {
            var r = new Regex(@"^[\w-]*$");
            if(!r.IsMatch(validator.Value.ToString()))
            {
                throw new ArgumentOutOfRangeException(validator.ArgumentName, "string is not word or number or line");
            }
            return validator;
        }
    }
}
