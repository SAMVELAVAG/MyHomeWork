// See https://aka.ms/new-console-template for more information
Console.WriteLine("");

//4.

//Console.Write("input your x number degree: ");
//double x1 = double.Parse(Console.ReadLine());
//Console.Write("input your x number: ");
//double x2 = double.Parse(Console.ReadLine());

//double ln_ex = Math.Log(Math.Exp(x1) + 1);
//double sqrt_x = Math.Pow(x2, 2) + 4;
//double sqrt_y = Math.Cbrt(sqrt_x);
//double result = ln_ex + sqrt_y;

//Console.WriteLine($"Log Result: {ln_ex}");
//Console.WriteLine($"Sqrt Result: {sqrt_y}");
//Console.WriteLine($"Our Result = {ln_ex} + {sqrt_y} = {result} ");


//8.

//Console.Write("Input your X number: ");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Input your Y number: ");
//double y = double.Parse(Console.ReadLine());

//double sqrx = Math.Pow(x, 2);
//double sqry = Math.Pow(y, 2) + 4;
//double cbrt = Math.Cbrt(sqry);
//double sum1 = sqrx + cbrt;
//double result1 = Math.Pow(sum1, 0.25);

//double modx = Math.Abs(x);
//double mody = Math.Abs(y);
//double sum2 = modx + mody;
//double result2 = Math.Pow(sum2, 10);
//double result = result1 + result2;

//Console.WriteLine($"Left Result: {result1}");
//Console.WriteLine($"Right Result: {result2}");
//Console.WriteLine($"General Result: {result1} + {result2} = {result}");


//12.

//double el = 0;
//Console.Write("Input x: ");
//double x = double.Parse(Console.ReadLine());
//Console.Write("Input a: ");
//double a = double.Parse(Console.ReadLine());
//double y;

//if (-5 <= x && x <= 5)
//{
//    y = Math.Pow(Math.Pow(a, 2) + 1, 6);
//    Console.WriteLine($"Y = {y}");
//}
//else if (x > 5)
//{
//    y = Math.Pow(Math.Cos(Math.Log(Math.Abs(x))), 2) + Math.Pow(x,8);
//    Console.WriteLine($"Y = {y}");
//}
//else
//{
//    el = a;
//    Console.WriteLine($"Y = {el}");
//}


//11․

//Console.Write("Input a: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Input b: ");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Input x: ");
//double x = double.Parse(Console.ReadLine());
//double ifab = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
//double y = 0;

//double ab = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2) + 5;
//double log3 = Math.Log(ab, 3);
//double e = 3 * Math.Exp(a - x);

//if (ifab > 5)
//{
//    y = e + log3;
//    Console.WriteLine($"Y = {y}");
//}
//else if (ifab < 1)
//{
//    y = Math.Pow(Math.Tan(a + b), 4);
//    Console.WriteLine($"Y = {y}");
//}
//else
//{
//    y = -3;
//    Console.WriteLine($"Y = {y}");
//}


//74.

//double y;

//for (double x = -3.8; x < 5.4; x+=0.3)
//{
//    y = Math.Pow(2, x + 4);
//    Console.WriteLine($"2^({x} + 4) = {y}");
//}

//77.

//double x = double.Parse(Console.ReadLine());
//double y;

//for (double i = -8; i < 8; i+=3)
//{
//    if (x > 3)
//    {
//        y = Math.Pow(i, 2) + (4 * Math.Pow(i, 8));
//        Console.WriteLine($"Y = {y}");
        
//    }
//    else
//    {
//        y = 0;
//        Console.WriteLine($"Y = {y}");
//        break;
//    }
//}





// 111.

//double x = 5;
//double sum ;
//double sqr;
//for (int n = 0; n < 10; n++)
//{
//    sqr = (4 * n) + 1;
//    sum = x + Math.Pow(x,sqr) / sqr;
//    Console.WriteLine(sum);
//}

// 118.

//double x = 4;
//double mod;

//for (int n = 0; n < 10; n++)
//{
//    mod = Math.Pow(Math.Abs(2 * x + n), n) / ((n + 1) * (n + 2));
//    Console.WriteLine(mod);
//}







