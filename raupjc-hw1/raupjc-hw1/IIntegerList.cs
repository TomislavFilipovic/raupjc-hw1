﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raupjc_hw1
{
    public interface IIntegerList
    {
        /// <summary >
        /// Adds an item to the  collection.
        ///  </summary >
        void Add(int item);
        /// <summary >
        /// Removes  the  first  occurrence  of an item  from  the  collection.
        /// If the  item  was  not found , method  does  nothing  and  returns  false.
        ///  </summary >
        bool Remove(int item);
        /// <summary >
        /// Removes  the  item at the  given  index in the  collection.
        /// Throws  IndexOutOfRange  exception  if  index  out of  range.
        ///  </summary >
        bool RemoveAt(int index);
        /// <summary >
        /// Returns  the  item at the  given  index in the  collection.
        /// Throws  IndexOutOfRange  exception  if  index  out of  range.
        ///  </summary >
        int GetElement(int index);
        /// <summary >
        /// Returns  the  index of the  item in the  collection.
        /// If item is not  found in the  collection , method  returns  -1.
        ///  </summary >
        int IndexOf(int item);
        /// <summary >
        /// Read only  property. Gets  the  number  of  items  contained  in the collection.
        ///  </summary >
        int Count { get; }
        /// <summary >
        /// Removes  all  items  from  the  collection.
        ///  </summary >
        void Clear();
        /// <summary >
        /// Determines  whether  the  collection  contains a specific  value.
        ///  </summary >
        bool Contains(int item);
    }
}
