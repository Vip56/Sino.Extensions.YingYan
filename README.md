## 百度鹰眼.Net Core SDK
由于存在大量使用百度鹰眼的Restful Api为便于后期的开发和维护，故单独编写对应类库进行封装便于开发和调试。   

## 项目结构
1. src/Common：公用部分   
2. src/Terminal：终端管理   
3. src/Utils：工具类   
4. src/Fence：地理围栏   

## 注意部分  

#### 参数校验扩展   
考虑到实际开发情况基本的参数校验类库无法满足所有的情况，如需要扩张请在`src/Utils/ConditionValidatorExtension`文件中按照规范进行扩展，如以下方式即可：   
```
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
```

## 依赖类库   
* [Conditions参数验证](https://github.com/mnaumank/conditions)
* [RestSharp网络请求](https://github.com/restsharp/RestSharp/)