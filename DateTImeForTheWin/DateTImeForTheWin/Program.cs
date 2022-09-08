// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, DateTime!");

DateTime datetime = new ();
Console.WriteLine(datetime); // 0001-01-01 00:00:00

datetime = new(2022, 09, 08);
Console.WriteLine(datetime);

datetime = new(2022, 09, 08, 12,32,05);
Console.WriteLine(datetime);

// Text till datumformat
datetime = DateTime.Parse("2020-02-14 13:37");

// ToString("F") förvandlar den till mänskligt läsbar text
// den 20 januari 2022 00:00:00
datetime = Convert.ToDateTime("20 january 2020 14:30");
Console.WriteLine(datetime.ToString("F"));

datetime = new DateTime(1970,07,20).AddMonths(-9).AddHours(3).AddMinutes(2);
Console.WriteLine(datetime);

datetime = DateTime.Now; // Just nu!
Console.WriteLine(datetime.AddDays(10));
Console.WriteLine(datetime.AddDays(10).DayOfWeek);

DateTime today = DateTime.Now;
DateTime christmas = new DateTime(today.Year, 12, 24);
double days = (christmas - today).TotalDays;
Console.WriteLine($"Det är {days} kvar till jul.");

