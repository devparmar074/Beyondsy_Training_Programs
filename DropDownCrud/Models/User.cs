using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;

namespace DropDownCrud.Models
{
    public class User
    {
        public TeaType SelectTeaType { get; set; }
    }

    public enum TeaType
    {
        Tea,
        Coffee,
        BlackCoffee,
        GreenTea
    }
}