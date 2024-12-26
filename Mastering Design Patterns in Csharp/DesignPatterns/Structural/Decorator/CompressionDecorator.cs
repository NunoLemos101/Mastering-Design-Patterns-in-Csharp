namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Structural.Decorator;

public class CompressionDecorator : DataDecorator
{
    public CompressionDecorator(IData data) : base(data) { }

    public override void Save(string data)
    {
        Console.WriteLine("Compressing data");
        var compressed = Compress(data);
        _data.Save(compressed);
    }

    private string Compress(string data)
    {
        return data.Substring(0, 9); // pretend to compress data
    }
}