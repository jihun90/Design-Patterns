namespace Chocolate.ChocolateBoiler;

public class ChocolateBoiler
{
    private bool boided;
    private bool empty;
    private static Lazy<ChocolateBoiler>? lazyInstance;

    private ChocolateBoiler()
    {
        boided = false;
        empty = false;
    }

    public static ChocolateBoiler GetInstance()
    {
        if (lazyInstance == null) 
        {
            lazyInstance = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());
        }

        return lazyInstance.Value;
    }

    public void fill()
    {
        if (IsEmpty)
        {
            empty = false;
            boided = false;
        }
    }

    public void drain() 
    {
        if(!IsEmpty && IsBoided)
        {
            empty = true;
        }
    }

    public void Boil()
    {
        if(!IsEmpty && !IsBoided)
        {
            boided = true;
        }
    }


    public bool IsBoided => boided;
    public bool IsEmpty => empty;
}