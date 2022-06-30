using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//namespace SysManager.Application.Helpers
//{
//    public static class ValidationResultRepository
//    {
//        public static async Task<ValidationResult> ValidateRepositoryAsync<TModel, TRepository>(this ValidationResult validaResultExtension, TModel model, TRepository repository) where TModel : class where TRepository : class
//        {
//            Validate<TModel, TRepository>(model, repository);
//            foreach (var item in listValidationFailure)
//                validaResultExtension.Errors.Add(item);

//            return await Task.FromResult(validaResultExtension);
//        }
//        static IList<ValidationFailure> listValidationFailure;

//        static void Validate<TModel, TRepository>(TModel model, TRepository repository) where TModel : class where TRepository : class
//        {
//            var lista = GetAssemblies<TModel, TRepository>();
//            listValidationFailure = new List<ValidationFailure>();

//            foreach (var @type in lista)
//            {
//                object instance = Activator.CreateInstance(@type);

//                MethodInfo method = @type.GetMethod("Validate");

//                if (method == null)
//                {
//                    return;
//                }

//                object[] parameter = new object[2];
//                parameter[0] = model;
//                parameter[1] = repository;

//                object value = method.Invoke(instance, parameter);

//                if (((ValidationFailureCustom)value).Haserrors)
//                    listValidationFailure.Add((ValidationFailureCustom)value);
//            }
//        }


//        private static MemoryCache _cache = new MemoryCache(new MemoryCacheOptions());

//        static IEnumerable<Type> GetAssemblies<TModel, TRepository>() where TModel : class where TRepository : class
//        {
//            string nameCache = typeof(TModel).FullName;
//            var currentAssemblies = _cache.Get<IEnumerable<Type>>(nameCache);

//            if (currentAssemblies != null)
//            {
//                return currentAssemblies;
//            }

//            var _assemblies = from x in AppDomain.CurrentDomain.GetAssemblies()
//                              from y in x.GetTypes()
//                              where typeof(IValidationRepository<TModel, TRepository>).IsAssignableFrom(y)
//                              select y;

//            var _cacheExpirationOptions = new MemoryCacheEntryOptions();
//            _cacheExpirationOptions.AbsoluteExpiration = DateTime.Now.AddDays(1);
//            _cacheExpirationOptions.Priority = CacheItemPriority.Normal;
//            _cache.Set<IEnumerable<Type>>(nameCache, _assemblies, _cacheExpirationOptions);
//            return _assemblies;


//        }


//    }
//}
    

