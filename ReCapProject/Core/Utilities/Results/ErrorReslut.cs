using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorReslut:Result
    {
        public ErrorReslut(string message) : base(false, message)
        {

        }
        //mesaj göndermek istemezsek kullanılır
        public ErrorReslut() : base(false)
        {

        }
    }
}
