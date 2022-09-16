using System;

namespace PostfixEvaluate
{
    class Evaluate
    {
        static void Main(string[] args)
        {
            string infix;
            Console.Write("Enter the expression:");
            infix = Console.ReadLine();
            string postfix = InfixtoPostFix(infix);

        }

        public static string InfixtoPostFix(string infix)
        {
            string postfix = "";
            StackChar st = new StackChar(20);

            char next, symbol;
            for(int i  = 0; i < infix.Length; i++)
            {
                symbol = infix[i];
                if (infix[i] == ' ' || infix[i] == '\t')
                    continue;
                switch (symbol)
                {
                    case '(':
                        st.Push(symbol);
                        break;
                    case ')':
                        while ((next = st.Pop()) != '(')
                            postfix = postfix + next;
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '^':
                    case '%':
                        while(!st.IsEmpty() && Precedence(symbol) <= Precedence(st.Peek()))
                        {
                            postfix = postfix + st.Pop();
                        }
                        st.Push(symbol);
                        break;
                    default:
                        postfix = postfix + symbol;
                        break;

                }
            }
            return postfix;
        }
        private static int Precedence(char c)
        {
            switch (c)
            {
                case '(':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '/':
                case '%':
                case '*':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
