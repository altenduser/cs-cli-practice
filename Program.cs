if (args.Length == 0)
Console.WriteLine("Exception: Invalid Argument Integrity.");

switch (args[0])
{
    case "manual":
    Console.WriteLine("Exception: No Modules available for use.");
    break;

    default:
    Console.WriteLine($"Error: unavail-able module '{args[0]}'.");
    break;
}