using System;

class InstructionSet_fixed
{
    static void Main()
    {
        string opCode = "";

        while (true)
        {
            opCode = Console.ReadLine();
            string[] codeArgs = opCode.Split(' ');
            if (codeArgs[0] == "END") break;
            decimal result = 0;
            switch (codeArgs[0])
            {
                case "INC":
                    {
                        decimal operandOne = decimal.Parse(codeArgs[1]);
                        result = operandOne + 1;
                        Console.WriteLine(result);
                        break;
                    }
                case "DEC":
                    {
                        decimal operandOne = decimal.Parse(codeArgs[1]);
                        result = operandOne - 1;
                        Console.WriteLine(result);
                        break;
                    }
                case "ADD":
                    {
                        decimal operandOne = decimal.Parse(codeArgs[1]);
                        decimal operandTwo = decimal.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        Console.WriteLine(result);
                        break;

                    }
                case "MLA":
                    {
                        decimal operandOne = decimal.Parse(codeArgs[1]);
                        decimal operandTwo = decimal.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        Console.WriteLine(result);
                        break;
                    }
            }
        }
    }
}