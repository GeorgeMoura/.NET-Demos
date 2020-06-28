using System;
using System.Collections.Generic;
using System.Text;
using LinqDemo.Models;

namespace LinqDemo.Controllers
{
    class ReadController
    {
        public ReadController()
        {
        }

        public List<string[]> read(IRead readObject)
        {
            return readObject.read();
        }
    }
}
