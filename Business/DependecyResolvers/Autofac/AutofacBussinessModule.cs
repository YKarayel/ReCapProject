using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concreate;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Core.Utilities.Interceptors;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Helpers;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;
using Core.Utilities.Security.JWT;

namespace Business.DependecyResolvers.Autofac
{
    public class AutofacBussinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            //Managers, Services
            builder.RegisterType<BrandManager>().As<IBrandManager>().SingleInstance();
            builder.RegisterType<CarManager>().As<ICarManager>().SingleInstance();
            builder.RegisterType<ColorManager>().As<IColorManager>().SingleInstance();
            builder.RegisterType<CustomerManager>().As<ICustomerManager>().SingleInstance();
            builder.RegisterType<RentalManager>().As<IRentalManager>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserManager>().SingleInstance();
            builder.RegisterType<CarImageManager>().As<ICarImageManager>().SingleInstance();
			builder.RegisterType<AuthManager>().As<IAuthService>();



			//Data Access Layers and Helpers
			builder.RegisterType<BrandDal>().As<IBrandDal>().SingleInstance();
            builder.RegisterType<CarDal>().As<ICarDal>().SingleInstance();
            builder.RegisterType<ColorDal>().As<IColorDal>().SingleInstance();
            builder.RegisterType<CustomerDal>().As<ICustomerDal>().SingleInstance();
            builder.RegisterType<RentalDal>().As<IRentalDal>().SingleInstance();
            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<CarImageDal>().As<ICarImageDal>().SingleInstance();
            builder.RegisterType<FileHelper>().As<IFileHelper>().SingleInstance();
			builder.RegisterType<JwtHelper>().As<ITokenHelper>();
			builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();






			var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
