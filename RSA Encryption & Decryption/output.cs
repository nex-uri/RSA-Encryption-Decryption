namespace RSA_Encryption___Decryption
{
    internal class output_ed
    {
        private long receiver_prime_d;
        private long receiver_prime_n;
        private long[] receiver_encrypted_arr;

        public output_ed(long decryption_key, long prime_key_n, long[] data_arr)
        {
            receiver_prime_d = decryption_key;
            receiver_prime_n = prime_key_n;
            receiver_encrypted_arr = data_arr;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[OK] \t\t");
            Console.ResetColor();
            Console.WriteLine($"The data has been SENT to the instance.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.ResetColor();
            enc_data_output();
        }

        public void enc_data_output()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\t===================================Output===================================\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[DISCLAIMER] ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("DO NOT share these to others in public as they may decrypt and retrieve your data.\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[ENCRYPTED MESSAGE] \t");
            Console.ResetColor();

            for (int i = 0; i < receiver_encrypted_arr.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{receiver_encrypted_arr[i]} ");
                Console.ResetColor();
            }

            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[PRIME KEY] \t\t");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{receiver_prime_n}\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[DECRYPTION KEY] \t");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{receiver_prime_d}");
            Console.ResetColor();
        }
    }
}
