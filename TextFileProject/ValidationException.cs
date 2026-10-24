using System;
using System.Collections.Generic;
using System.Text;

namespace TextFileProject
{
    internal class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }

    public static class InputValidator
    {
        public static void FileName(string value)
        {
            Required(value, "File name");
            if (value.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                throw new ValidationException("File name contains invalid characters (\\ / : * ? \" < > |).");
        }

        public static void Required(string value, string field)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ValidationException(field + " is required.");
        }

        public static void DigitsOnly(string value, string field, int minLen = 1, int maxLen = int.MaxValue)
        {
            Required(value, field);
            if (!value.All(char.IsDigit))
                throw new ValidationException(field + " must contain numbers only.");
            if (value.Length < minLen || value.Length > maxLen)
                throw new ValidationException(field + " must be " + minLen + "-" + maxLen + " digits.");
        }

        public static void LettersOnly(string value, string field)
        {
            Required(value, field);
            if (!value.All(c => char.IsLetter(c) || c == ' ' || c == '-'))
                throw new ValidationException(field + " must contain letters only.");
        }

        public static int Age(string value)
        {
            Required(value, "Age");
            if (!int.TryParse(value, out int age))
                throw new ValidationException("Age must be a number.");
            if (age < 1 || age > 120)
                throw new ValidationException("Age must be between 1 and 120.");
            return age;
        }

        public static void Birthday(DateTime date)
        {
            if (date.Date > DateTime.Today)
                throw new ValidationException("Birthday cannot be in the future.");
        }

        public static void Selected(ComboBox cmb, string field)
        {
            if (cmb.SelectedIndex == -1)
                throw new ValidationException("Please select a " + field + ".");
        }
    }
}
