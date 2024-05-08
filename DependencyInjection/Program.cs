using Autofac;
using DependencyInjection;
using SimpleInjector;

//var b = new B(new A());

//var d = new D(new C(new B(new A())), new B(new A()));

// Autofac

//ContainerBuilder containerBuilder = new();
////containerBuilder.RegisterInstance(new A(1)).As<A>();
//containerBuilder.RegisterType<A>();
//containerBuilder.RegisterType<B>();
//containerBuilder.RegisterType<C>();
//containerBuilder.RegisterType<Sirab>().As<Water>();
//containerBuilder.RegisterType<D>().SingleInstance();
//var container = containerBuilder.Build();

////var c = container.Resolve<C>();
////var b = container.Resolve<B>();
////Console.WriteLine(c.Text);

//var c = container.Resolve<D>();
//var c1 = container.Resolve<D>();

//c.Text = "kamil";

//Console.WriteLine(c1.Text);


// Ninject
// SimpleInjector

//Container container = new Container();
//container.Register<A>();
//container.RegisterSingleton<B>();
//container.Register<C>();
//container.Register<D>();
//container.Register<Water, Sirab>();



//var c = container.GetInstance<C>();

// IoC

