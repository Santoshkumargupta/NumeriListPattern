
using System.Numerics;

var result = AddAll(new[] { 1, 2, 3, 4, 5 });

Console.WriteLine(result);

T AddAll<T>(T[] values) where T : INumber<T> => values switch
{
    [] => T.Zero,
    [var first,.. var rest] => first + AddAll(rest)

};
