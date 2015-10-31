using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brello.Models
{
    public interface ICar
    {
        string Horn();
    }

    public class Car
    {
        // make class virtual in order to override behavior using Mock
        public virtual string Horn()
        {
            this.ReadyEngines();
            return "Honk!";
        }

        public virtual void ReadyEngines()
        {

        }
    }
}
