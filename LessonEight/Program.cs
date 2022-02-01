// Nullable data types
// If you put the sign "?", then it is "possible" that the variable has the value "null"
string? str = null;
object? obj = null;
int? num = default;
int? n = null;
int? nu = 1;


Console.WriteLine(str == null ? "null" : "not null"); // null
Console.WriteLine(obj == null ? "null" : "not null"); // null
Console.WriteLine(num == null ? "null" : "not null"); // null
Console.WriteLine(n == null ? "null" : "not null"); // null
Console.WriteLine(nu == null ? "null" : "not null"); // not null