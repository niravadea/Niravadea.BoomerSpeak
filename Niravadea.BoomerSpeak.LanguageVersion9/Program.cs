System.Console.WriteLine(
    System.Linq.Enumerable.Aggregate(
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", // source
        (new System.Text.StringBuilder(), false),   // seed
        (acc, c) => (acc.Item1.Append(char.IsLetter(c) ? ((acc.Item2 = !acc.Item2) ? char.ToUpper(c) : char.ToLower(c)) : c), acc.Item2),   // func
        acc => acc.Item1.ToString() // resultSelector
    )
);
