namespace CarWorldScene;

public class Car
{
    public float Fuel;
    public float Speed;
    public float Traction;
    public string WheelType;

    public float Stock = 0.75f;
    public float Drift = 0.32f;
    public float Grip = 1f;

    public Car(float fuel, string wheelType)
    {
        Fuel = Math.Clamp(fuel, 0f, 100f);
        WheelType = wheelType;
        Traction = wheelType.ToLower() switch
        {
            "grippy" => Grip,
            "slippery" => Drift,
            _ => Stock // default traction for "stock" wheels
        };
        Speed = 0f;
    }
}
