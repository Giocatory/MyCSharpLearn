int a = 1;
int b = 2;
int z;

// simple method
Console.WriteLine($"{AddNum(a, b)}\na={a}\nb={b}\n"); // 2 + 3 = 5, a=1, b=2

// method with ref parameters
Console.WriteLine($"{AddNumRef(ref a, ref b)}\na={a}\nb={b}\n"); // 2 + 3 = 5, a=2, b=3

// method with out parameters
AddNumOut(a, b, out int c, out z);
Console.WriteLine(c); // 5
Console.WriteLine(z); // 25

// method with params parameters
int[] nums = ArrParams(a, b, c, z);
Console.WriteLine(nums); //System.Int32[]
foreach (int num in nums) { Console.Write($"{num} "); } // 2 3 5 25

Console.WriteLine($"\n" +
    $"{MiddleValue(nums):f2}"
); // 8.75

// optional parameters (int a = 10, int b = 10)
OptionalParam(); //20
OptionalParam(a = 5); // 15
OptionalParam(b = 3); // 13
OptionalParam(a = 2, b = 3); // 5

// locals methods
Wrapper(5, 10); // 15


// Simple create method
static int AddNum(int x, int b) => ++x + ++b; // "=> x + b" the same -> return x + b;

static int AddNumRef(ref int x, ref int b) => ++x + ++b;

static void AddNumOut(int x, int b, out int c, out int z)
{
    c = x + b;
    z = c * c;
}

static int[] ArrParams(params int[] x) => x;

static double MiddleValue(params int[] x)
{
    double sum = 0;
    for (int i = 0; i < x.Length; i++) { sum += x[i]; }
    return sum / x.Length;
}

static void OptionalParam(int a = 10, int b = 10) => Console.WriteLine(a + b);


static void Wrapper(int x, int y)
{
    Console.WriteLine(Inner(x, y));
    static int Inner(int x, int y)
    {
        return x + y;
    }
}