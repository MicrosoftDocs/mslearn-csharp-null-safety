string first = string.Empty!;
string second;
string? third;

_ = first.ToString();
_ = second.ToString();
_ = third.ToString();

// Declare variable and assign it as null.
FooBar? fooBar = null;

// Dereference variable by calling ToString.
// This will throw a NullReferenceException.
_ = fooBar.ToString();

// The FooBar type definition for example.
record FooBar(int Id, string Name);