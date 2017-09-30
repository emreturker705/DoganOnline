using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace NewsProject.Ioc
{
    public static class IocContainer
    {
        private static IUnityContainer _container;
        public static IUnityContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = new UnityContainer();

                }
                return _container;
            }
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        public static void RegisterInstance<T>(T instance)
        {
            Container.RegisterInstance<T>(instance);
        }

        public static void RegisterTo<TI, TT>()
            where TT : class, TI
            where TI : class
        {
            Container.RegisterType<TI, TT>();
        }
    }
}
