using System;
/*
public class Rational
{
    private int Z { get; }
    private int N { get; }

    public Rational(int z, int n)
    {
        Z = z;
        N = n;
    }
// @Override ken f JAVA !!!!!
    public override string ToString()
    {
        return "(" + Z + "/" + N + ")";
    }

    public static Rational operator *(Rational l, Rational r)
    {
        return new Rational(l.Z * r.Z, l.N * r.N);
    }
}
*/








public class Rational
{
    int R { get ;}
int Z { get;}

public Rational(int r ,int z )
{
    R=R;
    Z=z;

}
public override string ToString()
{
    return "("+R +"/"+Z+")";
}
public static Rational operator *(Rational l , Rational r)
    {
        return new Rational(l.R * r.R, l.Z * r.Z);
    }


}







