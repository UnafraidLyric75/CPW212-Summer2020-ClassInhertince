using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    /// <summary>
    /// Represents a salable object
    /// </summary>
    class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        /// <summary>
        /// Return a display string that represents current product
        /// </summary>
        /// <returns></returns>
        //public string GetDisplayText()
        //{
        //    return $"{Name} costs {Price}";
        //}

        public virtual string GetDisplayText() => $"{Name} costs {Price}";
    }

    /// <summary>
    /// 
    /// </summary>
    class Book : Product
    {
        public string Isbn { get; set; }

        public string Author { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    class Software : Product
    {
        /// <summary>
        /// The version number of the software ex.
        /// 7.81.36
        /// </summary>
        public string Verison { get; set; }

        public string ProductKey { get; set; }

        public override string GetDisplayText()
        {
            return base.ToString();
        }
    }
}
