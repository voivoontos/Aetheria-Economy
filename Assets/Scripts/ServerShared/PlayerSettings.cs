using System;
using System.Globalization;
using MessagePack;

[MessagePackObject, Serializable]
public class PlayerSettings
{
    [Key(0)] public string Name = "Anonymous";
    [Key(1)] public SavedGame CurrentRun;
    [Key(2)] public TemperatureUnit TemperatureUnit = TemperatureUnit.Celsius;
    [Key(3)] public int SignificantDigits = 3;

    public string FormatTemperature(float t)
    {
        return TemperatureUnit switch
        {
            TemperatureUnit.Kelvin => $"{Format(t)}°K",
            TemperatureUnit.Celsius => $"{Format(t - 273.15f)}°C",
            TemperatureUnit.Fahrenheit => $"{Format((t - 273.15f) * (9f / 5) + 32)}°F",
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public float ParseTemperature(string s)
    {
        var t = float.Parse(s);
        return TemperatureUnit switch
        {
            TemperatureUnit.Kelvin => t,
            TemperatureUnit.Celsius => t + 273.15f,
            TemperatureUnit.Fahrenheit => (t - 32) * (5f / 9) + 273.15f,
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    public string Format(float d)
    {
        var magnitude = d == 0.0f ? 0 : (int)Math.Floor(Math.Log10(Math.Abs(d))) + 1;
        SignificantDigits -= magnitude;
        if (SignificantDigits < 0)
            SignificantDigits = 0;
        var strdec = d.ToString($"N{SignificantDigits}");
        var dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        return strdec.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator) ? strdec.TrimEnd('0').TrimEnd(dec) : strdec;
    }
}