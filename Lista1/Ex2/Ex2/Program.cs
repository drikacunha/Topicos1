// See https://aka.ms/new-console-template for more information

using Ex2;

Console.WriteLine("Hello, World!");


CelularFactory factory;

factory = new Nokia();
factory = new Motorola();
factory = new Apple();

Celular celular = factory.CreateCelular(TipoCelular.Fabrica);

factory.MontarCelular(TipoCelular.Fabrica);

factory = new Nokia();
factory = new Motorola();
factory = new Apple();
