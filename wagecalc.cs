double hours, rate, grossWage = 0.0; // initializing variables
double regWage = 0.0; // regular wage
double otWage = 0.0; // overtime wage
// hard coded values for hours and rate
hours = 30.75;
rate = 20.65;
// computing regular (if block) wage and overtime (else block) wage
    if (hours <= 40)
{
    regWage = hours * rate;
    otWage = 0.0;
}
    else
{
    regWage = rate * 40;
    otWage = (hours - 40.0) * 1.5 * rate;
}
grossWage = regWage + otWage;
// display wage
Console.WriteLine("Regular wage" + regWage.ToString("C")); // ToString("C") formats the string with a currecny character or something
Console.WriteLine("Overtime wage: {0:C} \nGross Wage: {1:C}", otWage, grossWage); // the {0:C} and {1:C} here are like the formatters in Python
// the first variable listed goes in the 0 spot, the next in the 1 spot
Console.WriteLine("Press any key to exit.");
Console.ReadLine();   