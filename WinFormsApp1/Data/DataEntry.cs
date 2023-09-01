using WinFormsApp1.Models;

namespace WinFormsApp1.Data
{
    public class DataEntry
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string BorderColor { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsDeleted { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Height { get; set; }
        public double DiagonalA { get; set; }
        public double DiagonalB { get; set; }
        public double Radius { get; set; }

        public DataEntry(string name, string borderColor, int x, int y, bool isDeleted)
        {
            Id = ((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds() * Shape.rnd.Next(int.MaxValue);
            Name = name;
            BorderColor = borderColor;
            X = x;
            Y = y;
            IsDeleted = isDeleted;
        }
    }
}
