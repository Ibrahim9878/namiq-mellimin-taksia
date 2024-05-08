namespace DependencyInjection;

internal class A
{
    public A()
    {
        
    }

}

class B
{
    public B(A obj) { }
}

class C
{
    public C(B obj) { }

    public string Text { get; set; } = "class C";
}

class D
{
    public D(C o, B o1, Water e)
    {

    }
}


abstract class Water
{


}


class Sirab : Water
{

}