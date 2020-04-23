using System;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public static class TextTable
    {
        /*

         Input: "Hello", 0
           +-----+
           |Hello|
           +-----+
           
         Input: $"Hello{Environment.NewLine}World!", 0
           +------+
           |Hello |
           |World!|
           +------+
           
         Input: "Hello", 1
           +-------+
           |       |
           | Hello |
           |       |
           +-------+

         */

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols. 
        /// </summary>
        public static string Build(string message, int padding)
        {
            string top = "";
            string middle = "";
            string bottom = "";
            string paddingFiller = "";
            int totalBorderLength = (message.Length + (padding * 2) + 1);

            // construct horizontal message border and padding filler
            for (int i = 0; i <= totalBorderLength; i++)
            {
                if (i == 0 || i == totalBorderLength)
                {
                    top += "+";
                    paddingFiller += "|";
                }
                else
                {
                    top += "-";
                    paddingFiller += " ";
                }
            }
            bottom = top;

            // construct middle message
            for (int i = 0; i <= totalBorderLength; i++)
            {
                if (i == 0 || i == (totalBorderLength - message.Length + 1))
                {
                    middle += "|";
                }
                else if (i == padding + 1)
                {
                    middle += message;
                }
                else
                {
                    middle += " ";
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(top);
            sb.Append(System.Environment.NewLine);

            for (int i = 0; i < padding; i++)
            {
                sb.Append(paddingFiller);
                sb.Append(System.Environment.NewLine);
            }

            sb.Append(middle);
            sb.Append(System.Environment.NewLine);

            for (int i = 0; i < padding; i++)
            {
                sb.Append(paddingFiller);
                sb.Append(System.Environment.NewLine);
            }

            sb.Append(bottom);

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
            return "";
        }
    }
}
