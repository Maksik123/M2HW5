using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW5.Providers
{
    public sealed class Logger
    {
        private static readonly Logger instance = new Logger();
        StringBuilder logText = new StringBuilder();

        static Logger()
        {
        }

        private Logger()
        {

        }

        public static Logger Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
