namespace DeserializationLatencyInvestigation
{
    public class TestModel
    {
        public Guid Guid1 { get; set; }
        public Guid? Guid2 { get; set; }
        public Enum1 Enum1 { get; set; }
        public Enum2 Enum2 { get; set; }
        public Enum3? Enum3 { get; set; }
        public decimal Decimal1 { get; set; }
        public decimal Decimal2 { get; set; }
        public decimal Decimal3 { get; set; }
        public decimal Decimal4 { get; set; }
        public decimal Decimal5 { get; set; }
        public decimal Decimal6 { get; set; }
        public decimal Decimal7 { get; set; }
        public decimal Decimal8 { get; set; }
        public decimal Decimal9 { get; set; }
        public decimal Decimal10 { get; set; }
        public decimal Decimal11 { get; set; }
        public decimal Decimal12 { get; set; }
        public decimal Decimal13 { get; set; }
        public decimal Decimal14 { get; set; }
        public decimal Decimal15 { get; set; }
        public decimal Decimal16 { get; set; }
        public decimal Decimal17 { get; set; }
        public bool? Bool1 { get; set; }
        public bool Bool2 { get; set; }
        public bool Bool3 { get; set; }
        public bool Bool4 { get; set; }
        public bool Bool5 { get; set; }
        public bool Bool6 { get; set; }
        public bool Bool7 { get; set; }
        public Model1 Model1_1 { get; set; }
        public Model1 Model1_2 { get; set; }
        public Model1 Model1_3 { get; set; }
        public Model2 Model2 { get; set; }
        public Model3 Model3 { get; set; }
        public Model4 Model4 { get; set; }
        public Model5 Model5 { get; set; }
        public Model6 Model6 { get; set; }
    }

    public enum Enum1
    {
        Value1,
        Value2,
        Value3,
    }

    public enum Enum2
    {
        Value1,
        Value2,
        Value3,
    }

    public enum Enum3
    {
        Value1,
        Value2,
        Value3,
    }

    public enum Enum4
    {
        Value1,
        Value2,
        Value3,
    }

    public enum Enum5
    {
        Value1,
        Value2,
        Value3,
    }

    public class Model1
    {
        public Guid Guid { get; set; }
        public decimal Decimal1 { get; set; }
        public decimal Decimal2 { get; set; }
        public decimal Decimal3 { get; set; }
        public decimal Decimal4 { get; set; }
        public decimal Decimal5 { get; set; }
        public decimal Decimal6 { get; set; }
        public float Float { get; set; }
        public string String { get; set; }
        public bool Bool { get; set; }
    }

    public class Model2
    {
        public Guid Guid1 { get; set; }
        public Guid? Guid2 { get; set; }
        public Guid? Guid3 { get; set; }
        public Guid? Guid4 { get; set; }
        public string String { get; set; }
        public decimal Decimal1 { get; set; }
        public decimal? Decimal2 { get; set; }
        public decimal? Decimal3 { get; set; }
        public decimal? Decimal4 { get; set; }
        public Enum4 Enum { get; set; }
        public bool Bool1 { get; set; }
        public bool? Bool2 { get; set; }
        public bool Bool3 { get; set; }
        public bool Bool4 { get; set; }
        public int? Int { get; set; }
    }

    public class Model3
    {
        public Guid Guid { get; set; }
        public decimal? Decimal1 { get; set; }
        public decimal? Decimal2 { get; set; }
        public decimal? Decimal3 { get; set; }
        public decimal? Decimal4 { get; set; }
        public Enum4? Enum1 { get; set; }
        public Enum4? Enum2 { get; set; }
        public bool Bool { get; set; }
    }

    public class Model4
    {
        public Enum5 Enum { get; set; }
        public float Float1 { get; set; }
        public float? Float2 { get; set; }
        public string String1 { get; set; }
        public string String2 { get; set; }
        public string String3 { get; set; }
        public string String4 { get; set; }
        public decimal Decimal1 { get; set; }
        public decimal? Decimal2 { get; set; }
    }

    public class Model5
    {
        public Guid? Guid { get; set; }
    }

    public class Model6
    {
        public Guid Guid { get; set; }
        public int Int { get; set; }
    }
}
