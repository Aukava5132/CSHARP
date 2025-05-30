namespace Lab7p2;

public class Registry
{
    private const int MaxDevices = 100;
    private IDevice[] devices = new IDevice[MaxDevices];
    private int count = 0;

    public void AddDevice(IDevice device)
    {
        if (count < MaxDevices)
        {
            devices[count] = device;
            count++;
        }
        else
        {
            Console.WriteLine("Реєстр переповнений!");
        }
    }

    public void ShowAllDevices()
    {
        Console.WriteLine("Весь реєстр обладнання:");
        for (int i = 0; i < count; i++)
        {
            devices[i].ShowInfo();
        }
    }

    public void ShowDevicesWithEngine()
    {
        Console.WriteLine("Обладнання з двигунами:");
        for (int i = 0; i < count; i++)
        {
            if (devices[i].HasEngine)
                devices[i].ShowInfo();
        }
    }

    public void ShowDevicesWithoutEngine()
    {
        Console.WriteLine("Обладнання без двигунів:");
        for (int i = 0; i < count; i++)
        {
            if (!devices[i].HasEngine)
                devices[i].ShowInfo();
        }
    }
    
    public void SortByEnginePresence()
    {
        int left = 0;
        int right = count - 1;

        while (left < right)
        {
            while (left < right && devices[left].HasEngine)
                left++;
            
            while (left < right && !devices[right].HasEngine)
                right--;
            
            if (left < right)
            {
                (devices[left], devices[right]) = (devices[right], devices[left]);
                left++;
                right--;
            }
        }
    }
    
    public void SortByName() 
    {
        for (int i = 0; i < count - 1; i++)
        {
            int maxIndex = i;
        

            for (int j = i + 1; j < count; j++)
            {
                if (string.Compare(devices[j].Name, devices[maxIndex].Name) > 0)
                {
                    maxIndex = j;
                }
            }
            
            if (maxIndex != i)
            {
                (devices[i], devices[maxIndex]) = (devices[maxIndex], devices[i]);
            }
        }
    }
    
    public IDevice[] CloneDevices()
    {
        IDevice[] clones = new IDevice[count];
        for (int i = 0; i < count; i++)
        {
            if (devices[i] is ICloneable cloneable)
            {
                clones[i] = (IDevice)cloneable.Clone();
            }
        }
        return clones;
    }
}