namespace ParanthesesValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression;

            Console.WriteLine("Enter an expression with paranthesis");
            expression = Console.ReadLine();

            if(IsValid(expression))
                Console.WriteLine("Valid expression");
            else
                Console.WriteLine("Invalid Expression");

        }
        static bool IsValid(string exp) 
        {
            StackA st = new StackA(exp.Length);
            char ch;
            for(int i=0;i<=exp.Length-1; i++)
            {
                if (exp[i] == '{' || exp[i]== '['|| exp[i] == '(')
                {
                    st.Push(exp[i]);
                }
                if (exp[i] == '}' || exp[i] == ']' || exp[i] == ')')
                {
                    if (st.IsEmpty())
                    {
                        Console.WriteLine("Right paranthesis is more than right paranthesis");
                        return false;
                    }
                    else
                    {
                        ch=st.Pop();
                        if (!MatchParanthesis(ch, exp[i])) {
                            Console.WriteLine("Mismatched paranthesis are "+ ch + "and "+ exp[i] );
                            return false;
                        }
                    }
                }
                
            }
            if (st.IsEmpty())
            {
                Console.WriteLine("equation is balanced");
                return true;
            }
            else
            {
                Console.WriteLine("Left paranthesis is > than right paranthesis");
                return false;
            }

        }
        static bool MatchParanthesis(int left, int right) 
        {
            if(left == '{' && right == '}')
            {
                return true;
            }   
            if(left == '[' && right == ']')
            {
                return true;
            }
            if(left == '(' && right == ')')
            {
                return true;
            }
            return false;
        }
    }

}
