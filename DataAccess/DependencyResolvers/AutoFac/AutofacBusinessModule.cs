using Autofac;
using AutoMapper;
using DataAccess.AutoMapper;
using DataAccess.Services.Concrete;
using DataAccess.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DependencyResolvers.AutoFac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //istek başı bu nesne bir adet üretilmesi sağlanır.
            builder.RegisterType<PersonRepository>().As<IPersonRepository>().InstancePerLifetimeScope();


            //Automapper configurasyonu
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new Mapping());
            });

            var mapper = mapperConfig.CreateMapper();
            builder.RegisterInstance<IMapper>(mapper);


        }
    }
}
