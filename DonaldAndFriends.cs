/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 12.11.2023
 *--------------------------------------------------------------
 * Description:
 * Who are you?
 *--------------------------------------------------------------
*/

using System;

namespace DonaldAndFriends
{
    public class Program
    {
        public static void Main()
        {
            char answer;

            Console.WriteLine("Wer bist du du? Darf ich es versuchen, es herauszufinden?");

            // Start Game
            Console.Write("Hmmm ... bist du ein Kind? <J/N> "); // first question
            answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'j' || answer == 'J')
            {
                Console.WriteLine("Grüß euch, Tick, Trick und Track !!!");
            }
            else
            {
                Console.Write("Bist du reich? <J/N> "); // secound question
                answer = Convert.ToChar(Console.ReadLine());

                if (answer == 'j' || answer == 'J')
                {
                    Console.WriteLine("Grüß dich, Dagobert Duck !!!");
                }
                else
                {
                    Console.Write("Hmmm ... bist du eine Ente? <J/N> "); // third question
                    answer = Convert.ToChar(Console.ReadLine());

                    if (answer == 'j' || answer == 'J')
                    {
                        Console.WriteLine("Grüß dich, Donald Duck !!!");
                    }
                    else
                    {
                        Console.Write("Bist du ein Hund? <J/N> "); // fourth question
                        answer = Convert.ToChar(Console.ReadLine());

                        if (answer == 'j' || answer == 'J')
                        {
                            Console.WriteLine("Grüß dich, Goofy !!!");
                        }
                        else
                        {
                            Console.WriteLine("Grüß dich, Mickey Mouse !!!");
                        }
                    }
                }
            }
        }
    }
}
