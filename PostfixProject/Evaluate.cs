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
            Console.WriteLine("Postfix expression is : " + postfix);

            Console.WriteLine("Value of expression : " + EvaluatePostFix(postfix));

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
            while (!st.IsEmpty())
            {
                postfix += st.Pop();
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
        private static int EvaluatePostFix(string postfix)
        {
            StackInt st = new StackInt(20);

            int x, y;
            for (int i = 0; i < postfix.Length; i++)
            {
                if (Char.IsDigit(postfix[i]))
                {
                    st.Push(Convert.ToInt32(Char.GetNumericValue(postfix[i])));
                }
                else
                {
                    x = st.Pop();
                    y = st.Pop();
                    switch (postfix[i])
                    {
                        case '+' :
                            st.Push(y + x);
                            break;
                        case '-':
                            st.Push(y - x);
                            break;
                        case '*':
                            st.Push(y * x);
                            break;
                        case '/':
                            st.Push(y / x);
                            break;
                        case '%':
                            st.Push(y % x);
                            break;
                        case '^':
                            st.Push(Power(y , x));
                            break;
                    }
                }
            }
            return st.Pop();
        }
        public static int Power(int b,int a)
        {
            int i, x = 1;
            for(i=0; i<a; i++)
            {
                x *= b;
            }
            return x;
        }
    }
}
