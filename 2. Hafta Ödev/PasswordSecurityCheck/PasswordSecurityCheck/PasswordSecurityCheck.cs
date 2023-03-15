namespace PasswordSecurityCheck
{
    public enum SecurityLevel
    {
        INVALID,
        LOW,
        MIDDLE,
        HIGH
    }
    public class PasswordCheck
    {
        /// <summary>
        /// Checks for numbers, letters and special characters in the input string
        /// </summary>
        /// <param name="PasswordInput"></param>
        /// <returns> It returns an enumeric value which defined in SecurityLevel. It can be INVALID,LOW,MIDDLE,HIGH.</returns>
        /// <exception cref="Exception">It is for invalid enumeric value. It can cause value miscalculation.</exception>
        public SecurityLevel CheckPasswordSecurity(string PasswordInput)
        {
            int tempSecurityLevel = 0;

            if (isPasswordValid(PasswordInput))
            {
                return SecurityLevel.INVALID;
            }
            else {
                if (isThereNumber(PasswordInput))
                {
                    tempSecurityLevel++;
                }
                if (isThereLetter(PasswordInput))
                {
                    tempSecurityLevel++;
                }
                if (isThereSpecialCharacter(PasswordInput))
                {
                    tempSecurityLevel++;
                } 

                switch (tempSecurityLevel)
                {
                    case 1:
                        return SecurityLevel.LOW;
                        break;
                    case 2:
                        return SecurityLevel.MIDDLE;
                        break;
                    case 3:
                        return SecurityLevel.HIGH;
                        break;
                    default:
                        throw new Exception("Invalid enumeric value for SecurityLevel!");
                }
            }

        }

        bool isPasswordValid(string PasswordInput)
        {
            if (PasswordInput.Length < 6)
                return true;
            else
                return false;
        }

        bool isThereNumber(string PasswordInput)
        {
            foreach (char c in PasswordInput)
            {
                if(char.IsNumber(c))
                {
                    return true;
                }
            }
            return false;
        }

        bool isThereLetter(string PasswordInput)
        {
            foreach (char c in PasswordInput)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        bool isThereSpecialCharacter(string PasswordInput)
        {
            foreach (char c in PasswordInput)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
