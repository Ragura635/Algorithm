Dictionary<string, int> resister = new Dictionary<string, int>();
resister.Add("black", 0);
resister.Add("brown", 1);
resister.Add("red", 2);
resister.Add("orange", 3);
resister.Add("yellow", 4);
resister.Add("green", 5);
resister.Add("blue", 6);
resister.Add("violet", 7);
resister.Add("grey", 8);
resister.Add("white", 9);

int input1 =  resister[Console.ReadLine()];
int input2 =  resister[Console.ReadLine()];
int input3 =  resister[Console.ReadLine()];

double ohm = (input1*10 + input2) * Math.Pow(10, input3);

Console.Write(ohm);