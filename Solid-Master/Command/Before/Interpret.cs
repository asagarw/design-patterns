// This code is implements a tiny interpreter for a couple of 
// bytecode instructions in CIL (Common Intermediate Language)
// This code is written in procedural style - refactor by applying 
// Object Oriented design principles (and optionally design patterns) 

using System;
using System.Collections.Generic;

namespace Solid_Master.Command.Before
{
    [Flags]
    internal enum BYTECODE : byte
    {
        LDCI4S = 0x10,
        MUL = 0x68,
        DIV = 0x6c,
        ADD = 0x60,
        SUB = 0x64
    }

    internal class Interpreter
    {
        private static readonly Stack<int> ExecutionStack = new Stack<int>();

        private static int Interpret(byte[] byteCodes)
        {
            var pc = 0;
            while (pc < byteCodes.Length)
                switch (byteCodes[pc++])
                {
                    case (byte) BYTECODE.ADD:
                        ExecutionStack.Push(ExecutionStack.Pop() + ExecutionStack.Pop());
                        break;
                    case (byte) BYTECODE.LDCI4S:
                        ExecutionStack.Push(byteCodes[pc++]);
                        break;
                }
            return ExecutionStack.Pop();
        }

        public static void Main()
        {
            // ((10 + 20) + 30)
            byte[] byteCodes =
            {
                (byte) BYTECODE.LDCI4S, 0x0A, (byte) BYTECODE.LDCI4S, 0x14, (byte) BYTECODE.ADD, (byte) BYTECODE.LDCI4S,
                0x1E, (byte) BYTECODE.ADD
            };
            var result = Interpret(byteCodes);
            Console.WriteLine("Execution result is: {0}", result);
            Console.ReadLine();
        }
    }
}