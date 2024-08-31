namespace WedukaEx1.Validators
{
    class ValidadorDeColchetes
    {
        public bool IsValidBrackets(string input)
        {
            // Verificar se os caracteres de entrada são válidos
            foreach (char c in input)
            {
                if (!IsValidCharacter(c))
                {
                    return false;
                }
            }

            // Verificar se todos os que foram abertos estão sendo fechados
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                if (IsOpenBracket(c))
                {
                    stack.Push(c);
                }
                else if (IsCloseBracket(c))
                {
                    if (stack.Count == 0 || !Matches(stack.Pop(), c))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        #region Validadores de caracteres

        private bool IsValidCharacter(char c)
        {
            return c == '(' || c == ')' || c == '[' || c == ']' || c == '{' || c == '}';
        }

        private bool IsOpenBracket(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        private bool IsCloseBracket(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        private bool Matches(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '[' && close == ']') ||
                   (open == '{' && close == '}');
        }
        #endregion
    }
}
