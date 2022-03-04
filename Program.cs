var a = new ValueTuple<int[], int>[]
{
	new ValueTuple<int[], int>(new[] { 0, 1 }, 1),
	new ValueTuple<int[], int>(new[] { 0, 1 }, 1)
};

for (var i1 = 0; i1 < a.Length; i1++)
{
	var length = a[i1].Item1.Length;
	
	for (var i2 = 0; i2 < length; i2++)
	{
		var elem = a[i1].Item1[i2];
		
		Console.WriteLine(elem);
	}
}
