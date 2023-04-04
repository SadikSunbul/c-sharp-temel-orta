// See https://aka.ms/new-console-template for more information


şekil s = new(2,2);
s.hesap();
üçgen u = new üçgen(2,2);
u.hesap();



class şekil
{
    public int _en;
    public int _boy;

    public şekil(int en,int boy)
    {
        _en = en;
        _boy = boy;
    }
   virtual public void hesap()
    {
        int değer = _en * _boy;
        Console.WriteLine(değer); 
    }
}

class üçgen:şekil
{
    public üçgen(int en,int boy):base(en ,boy)
    {

    }
    public override void hesap()
    {
        int hesap = _en * _boy / 2;

         Console.WriteLine(hesap) ;
    }

}

