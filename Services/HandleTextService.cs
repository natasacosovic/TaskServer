using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Services
{
    public class HandleTextService : IHandleTextService
    {
        public int CauntWords(string text)
        {
            try
            {
                int i = 0;
                int counter = 1;

                while (i <= text.Length - 1)
                {
                    if (text[i] == ' ' || text[i] == '\n' || text[i] == '\t')
                    {
                        counter++;
                    }

                    i++;
                }
                return counter;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
