using System;

interface ILightDevice
{
    string DeviceType { get; set; }
    string Brand { get; set; }
    int PowerInLumens { get; set; }
    string LightType { get; set; }
    int LightElementsCount { get; set; }

    void DisplayDetails();
    void ChangePower(int newPower);
}

interface IPhotographicDevice
{
    string DeviceType { get; set; }
    string Brand { get; set; }
    int OpticalLensSensitivity { get; set; }

    void DisplayDetails();
    void ChangeSensitivity(int newSensitivity);
}

class PhotoStudio : ILightDevice, IPhotographicDevice
{
    public string DeviceType { get; set; }
    public string Brand { get; set; }
    public int PowerInLumens { get; set; }
    public string LightType { get; set; }
    public int LightElementsCount { get; set; }

    public int OpticalLensSensitivity { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine("Light Device Details:");
        Console.WriteLine($"Device Type: {DeviceType}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Power in Lumens: {PowerInLumens}");
        Console.WriteLine($"Light Type: {LightType}");
        Console.WriteLine($"Light Elements Count: {LightElementsCount}\n");

        Console.WriteLine("Photographic Device Details:");
        Console.WriteLine($"Device Type: {DeviceType}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Optical Lens Sensitivity: {OpticalLensSensitivity}\n");
    }

    public void ChangePower(int newPower)
    {
        PowerInLumens = newPower;
        Console.WriteLine($"Power changed to: {newPower} lumens");
    }

    public void ChangeSensitivity(int newSensitivity)
    {
        OpticalLensSensitivity = newSensitivity;
        Console.WriteLine($"Sensitivity changed to: {newSensitivity}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PhotoStudio lightDevice1 = new PhotoStudio();
        lightDevice1.DeviceType = "Studio Lamp";
        lightDevice1.Brand = "ABC Lighting";
        lightDevice1.PowerInLumens = 2000;
        lightDevice1.LightType = "LED";
        lightDevice1.LightElementsCount = 5;

        PhotoStudio photoDevice1 = new PhotoStudio();
        photoDevice1.DeviceType = "Studio Camera";
        photoDevice1.Brand = "XYZ Cameras";
        photoDevice1.OpticalLensSensitivity = 800;

        lightDevice1.DisplayDetails();
        photoDevice1.DisplayDetails();

        photoDevice1.ChangeSensitivity(1000);
        photoDevice1.DisplayDetails();
    }
}
